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
using DTO;
using BLL;
using TST;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Ordem_Analise : MetroForm
    {
        public Frm_Ordem_Analise()
        {
            InitializeComponent();
        }
        int id_ordem = 0;
        // LOAD
        private void Frm_Ordem_Analise_Load(object sender, EventArgs e)
        {
            cbx_status.DataSource = new Listas_Status().Lista_Status_Ordem();
            Grid_Ordem("");
            Grid_Servicos(this.id_ordem);
        }
        // MODELO [DTO]
        private DTB_Consulta Consulta_Ordem(string pesquisa)
        {
            string ordem = DTB_Tabelas.Ordem_Servico;
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;

            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Sql_Command = $"SELECT {ordem}.ID, {ordem}.Status_Ordem, {cliente}.Nome, {veiculo}.Veiculo , {veiculo}.Placa, {ordem}.Data_Abertura, {ordem}.Data_Termino, {ordem}.Orcamento, {ordem}.Tempo_Estimado FROM {ordem} INNER JOIN {veiculo} ON {ordem}.ID_Veiculo = {veiculo}.ID INNER JOIN {cliente} ON {ordem}.ID_Responsavel = {cliente}.ID"

            };
            if (!(string.IsNullOrWhiteSpace(pesquisa)))
                dtb_consulta.str_Sql_Command += $" WHERE {cliente}.Nome LIKE '%{pesquisa}%' OR {veiculo}.Veiculo LIKE '%{pesquisa}%'";
            else
                dtb_consulta.str_Sql_Command += $" WHERE {ordem}.Status_Ordem LIKE '{cbx_status.Text}' ORDER BY {ordem}.ID DESC";

            return dtb_consulta;
        }
        private DTB_Consulta Consulta_Servico(int id_ordem)
        {
            string pendente = DTB_Tabelas.Servico_Pendente;
            string servico = DTB_Tabelas.Servico;
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = pendente,
                str_Tabela_Secundaria = servico,
                str_Parametros = $"{pendente}.ID_Servico, {pendente}.Status_Servico, {servico}.Nome, {servico}.Preco, {servico}.Tempo, {servico}.Observacoes",
                str_Parametro_Ordenador = $"{pendente}.ID_Servico",
                str_On_Join = $"{servico}.ID = {pendente}.ID_Servico",
                str_Condicao = $"{pendente}.ID_Ordem = {id_ordem}"
            };


            return dtb_consulta;
        }
        // OPERACOES [BLL]
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => new Consultas().Consultar(dtb_consulta);
        // OPERACOES 
        private int Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                return int.Parse(dgv_ordens.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            else
                return 0;
        }
        private void Popular_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            dgv_dataGrid.DataSource = Consultar_Banco(dtb_consulta);
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Grid_Servicos(int id_ordem)
        {
            Popular_DataGrid(dgv_servicos, Consulta_Servico(id_ordem));
            Nomear_Servico(dgv_servicos);
        }
        private void Grid_Ordem(string pesquisa)
        {
            Popular_DataGrid(dgv_ordens, Consulta_Ordem(pesquisa));
            Nomear_Ordem(dgv_ordens);
        }
        private void Nomear_Ordem(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Status";
            dgv_dataGrid.Columns[2].HeaderText = "Responsável";
            dgv_dataGrid.Columns[3].HeaderText = "Veículo";
            dgv_dataGrid.Columns[4].HeaderText = "Placa";
            dgv_dataGrid.Columns[5].HeaderText = "Abertura";
            dgv_dataGrid.Columns[6].HeaderText = "Término";
            dgv_dataGrid.Columns[7].HeaderText = "Orçamento";
            dgv_dataGrid.Columns[8].HeaderText = "Estimado (Hrs)";
        }
        private void Nomear_Servico(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Status";
            dgv_dataGrid.Columns[2].HeaderText = "Serviço";
            dgv_dataGrid.Columns[3].HeaderText = "Preço";
            dgv_dataGrid.Columns[4].HeaderText = "Estimado (Min)";
            dgv_dataGrid.Columns[5].HeaderText = "Observações";
        }
        // DATAGRID
        private void dgv_ordens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id_ordem = Get_ID(e);
            Grid_Servicos(this.id_ordem);
        }
        // BUTTON
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // TEXTBOX
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Grid_Ordem(txt_pesquisa.Text);
        // COMBOBOX
        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e) => Grid_Ordem("");
    }
}
