using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BLL;
using TST;
using DTO;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Ordem : MetroForm
    {
        public Frm_Ordem() => InitializeComponent();
        // LOAD
        private void Frm_Ordem_Load(object sender, EventArgs e)
        {
            Popular_ComboBox();
            Popular_DataGrid(dgv_ordens, Consulta_Ordem(0, ""));
        }
        // MODELOS [DTO]
        private DTB_Consulta Consulta_Ordem(int id_ordem, string pesquisa)
        {
            string ordem = DTB_Tabelas.Ordem_Servico;
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;

            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Sql_Command = $"SELECT {ordem}.ID, {ordem}.Status_Ordem, {cliente}.Nome, {veiculo}.Veiculo , {veiculo}.Placa ,{ordem}.Combustivel,  {ordem}.Orcamento,  CAST( {ordem}.Tempo_Estimado AS DECIMAL(18, 2)), {ordem}.Data_Abertura, {ordem}.Observacoes_Avaria, {ordem}.Observacoes_Cliente FROM {ordem} INNER JOIN {veiculo} ON {ordem}.ID_Veiculo = {veiculo}.ID INNER JOIN {cliente} ON {ordem}.ID_Responsavel = {cliente}.ID"

            };
            if (id_ordem > 0)
                dtb_consulta.str_Sql_Command += $" WHERE {ordem}.ID = {id_ordem}";
            else if (!(string.IsNullOrWhiteSpace(pesquisa)))
                dtb_consulta.str_Sql_Command += $" WHERE {cliente}.Nome LIKE '%{pesquisa}%' OR {veiculo}.Veiculo LIKE '%{pesquisa}%'";
            else
                dtb_consulta.str_Sql_Command += $" WHERE {ordem}.Status_Ordem LIKE '{cbx_status.Text}' ORDER BY {ordem}.ID DESC";

            return dtb_consulta;
        }
        // VALIDACOES [BLL]
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => !string.IsNullOrWhiteSpace(dtb_consulta.str_Sql_Command);
        // OPERACOES >> BLL
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        // OPERACOES
        private int Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                return int.Parse(dgv_ordens.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            else
                return 0;
        }
        private void Popular_ComboBox() => cbx_status.DataSource = new Listas_Status().Lista_Status_Ordem();
        private void Popular_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            dgv_dataGrid.DataSource = dt_table;
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Nomear_DataGrid(dgv_dataGrid);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Status";
            dgv_dataGrid.Columns[2].HeaderText = "Responsável";
            dgv_dataGrid.Columns[3].HeaderText = "Veículo";
            dgv_dataGrid.Columns[4].HeaderText = "Placa";
            dgv_dataGrid.Columns[5].HeaderText = "Comb.";
            dgv_dataGrid.Columns[6].HeaderText = "Orçamento";
            dgv_dataGrid.Columns[7].HeaderText = "Estimado (Hrs.)";
            dgv_dataGrid.Columns[8].HeaderText = "Abertura";
            dgv_dataGrid.Columns[9].HeaderText = "Observações de Avarias";
            dgv_dataGrid.Columns[10].HeaderText = "Observações do Cliente";
        }
        // TEXTBOX
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Popular_DataGrid(dgv_ordens, Consulta_Ordem(0, txt_pesquisa.Text));
        // BUTTONS
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_nova_ordem_Click(object sender, EventArgs e)
        {
            Frm_Abrir_Ordem_Servico frm_Abrir_Ordem_Servico = new Frm_Abrir_Ordem_Servico();
            frm_Abrir_Ordem_Servico.ShowDialog();
            Popular_DataGrid(dgv_ordens, Consulta_Ordem(0, ""));
        }
        // COMBOBOX
        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e) => Popular_DataGrid(dgv_ordens, Consulta_Ordem(0, ""));
        // DATAGRID
        private void dgv_ordens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_ordem = Get_ID(e);
            if (id_ordem > 0)
                new OPC_Ordem_Servico(id_ordem).ShowDialog();
            Popular_DataGrid(dgv_ordens, Consulta_Ordem(0, ""));
        }
    }
}
