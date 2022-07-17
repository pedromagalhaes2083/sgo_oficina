using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using TST;
using BLL;
using MetroFramework.Forms;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Registro_Servico : MetroForm
    {
        public Frm_Registro_Servico() => InitializeComponent();
        // VARIAVEIS
        int id_registro = 0;
        // LOAD
        private void Frm_Registro_Servico_Load(object sender, EventArgs e) => Prencher_DataGrid(Consulta_Registro(""));
        // MODELOS >> DTB
        private DTB_Consulta Consulta_Registro(string str_pesquisa)
        {
            string cliente = DTB_Tabelas.Cliente;
            string registro = DTB_Tabelas.Registro_Servico;

            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Sql_Command = $"SELECT {registro}.ID, {registro}.Data, {cliente}.Nome, {registro}.Descricao, {registro}.Preco, {registro}.Observacoes FROM {registro} INNER JOIN {cliente} ON {registro}.ID_Cliente = {cliente}.ID "
            };
            if (!string.IsNullOrWhiteSpace(str_pesquisa))
                dtb_consulta.str_Sql_Command += $" WHERE {cliente}.Nome LIKE '%{str_pesquisa}%' OR {cliente}.Apelido LIKE '%{str_pesquisa}%' ORDER BY {registro}.Data DESC";

            return dtb_consulta;
        }
        // VALIDACOES >> TST
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => !string.IsNullOrWhiteSpace(dtb_consulta.str_Sql_Command);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // OPERACOES >> BLL
        private DataTable Consulta_Banco(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        // OPERACOES 
        private int Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                return int.Parse(dgv_registro.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            else
                return 0;
        }
        private void Prencher_DataGrid(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consulta_Banco(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                dgv_registro.DataSource = dt_table;
                dgv_registro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            Nomear_DataGrid(dgv_registro);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Data";
                dgv_dataGrid.Columns[2].HeaderText = "Cliente";
                dgv_dataGrid.Columns[3].HeaderText = "Descrição";
                dgv_dataGrid.Columns[4].HeaderText = "Preço";
                dgv_dataGrid.Columns[5].HeaderText = "Observações";
            }
        }
        // BUTTON
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_novo_registro_Click(object sender, EventArgs e)
        {
            _ = new Frm_Cad_Registro_Servico().ShowDialog();
            Prencher_DataGrid(Consulta_Registro(""));
        }

        private void dgv_registro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id_registro = Get_ID(e);
            if(id_registro > 0)
            {
                new OPC_Registro_Servico(this.id_registro).ShowDialog();
                Prencher_DataGrid(Consulta_Registro(""));
            }
        }
    }
}
