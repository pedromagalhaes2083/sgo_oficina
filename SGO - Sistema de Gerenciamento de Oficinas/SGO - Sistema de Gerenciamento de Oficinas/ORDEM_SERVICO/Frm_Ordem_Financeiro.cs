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
using DTO;
using TST;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Ordem_Financeiro : MetroForm
    {
        public Frm_Ordem_Financeiro()
        {
            InitializeComponent();
        }
        int id_ordem = 0;
        // LOAD
        private void Frm_Ordem_Financeiro_Load(object sender, EventArgs e)
        {
            Prencher_ComboBox();
            Prencher_DataGrid(dgv_ordens, Consulta_Ordem(""));
        }
        // MODELOS [DTO]
        private DTB_Consulta Consulta_Ordem(string pesquisa)
        {
            string ordem = DTB_Tabelas.Ordem_Servico;
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;

            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Sql_Command = $"SELECT {ordem}.ID, {ordem}.Status_Ordem, {veiculo}.Veiculo , {cliente}.Nome, {veiculo}.Placa , {ordem}.Orcamento, {ordem}.Quitado , {ordem}.Tempo_Estimado, {ordem}.Data_Abertura, {ordem}.Data_Termino FROM {ordem} INNER JOIN {veiculo} ON {ordem}.ID_Veiculo = {veiculo}.ID INNER JOIN {cliente} ON {ordem}.ID_Responsavel = {cliente}.ID"

            };
            if (!(string.IsNullOrWhiteSpace(pesquisa)))
                dtb_consulta.str_Sql_Command += $" WHERE {cliente}.Nome LIKE '%{pesquisa}%' OR {veiculo}.Veiculo LIKE '%{pesquisa}%'";
            else
                dtb_consulta.str_Sql_Command += $" WHERE {ordem}.Status_Ordem LIKE '{cbx_status.Text}' ORDER BY {ordem}.ID DESC";

            return dtb_consulta;
        }
        // VALIDACOES [TST]
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => !string.IsNullOrWhiteSpace(dtb_consulta.str_Sql_Command);
        // OPERACOES [BLL]
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta)
        {
            if (Validar_Consulta(dtb_consulta))
                return new Consultas().Consultar(dtb_consulta);
            else
                return null;
        }
        // OPERACOES
        private void Prencher_ComboBox() => cbx_status.DataSource = new Listas_Status().Lista_Status_Ordem();
        private void Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.id_ordem = int.Parse(dgv_ordens.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
        private void Prencher_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            dgv_dataGrid.DataSource = dt_table;
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Nomear_DataGrid(dgv_dataGrid);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Status";
            dgv_dataGrid.Columns[2].HeaderText = "Veículo";
            dgv_dataGrid.Columns[3].HeaderText = "Responsável";
            dgv_dataGrid.Columns[4].HeaderText = "Placa";
            dgv_dataGrid.Columns[5].HeaderText = "Orçamento";
            dgv_dataGrid.Columns[6].HeaderText = "Quitado";
            dgv_dataGrid.Columns[7].HeaderText = "Estimado Hrs.";
            dgv_dataGrid.Columns[8].HeaderText = "Abertura";
            dgv_dataGrid.Columns[9].HeaderText = "Término";
        }
        // TEXTBOX
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Prencher_DataGrid(dgv_ordens, Consulta_Ordem(txt_pesquisa.Text));
        // DATAGRID
        private void dgv_ordens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_ID(e);
            _ = this.id_ordem > 0 ? btn_quitar.Enabled = true : btn_quitar.Enabled = false;
        }
        // BUTTON
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (this.id_ordem > 0)
                new Frm_Ordem_Quitar(this.id_ordem).ShowDialog();
            Prencher_DataGrid(dgv_ordens, Consulta_Ordem(""));
        }
        // COMBOBOX
        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e) => Prencher_DataGrid(dgv_ordens, Consulta_Ordem(""));
    }
}
