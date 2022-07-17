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
    public partial class Frm_Veiculo : MetroForm
    {
        public Frm_Veiculo()
        {
            InitializeComponent();
        }
        int id_veiculo = 0;
        // Modelos 
        private DTB_Consulta Consulta_Veiculo(string pesquisa)
        {
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = veiculo,
                str_Tabela_Secundaria = cliente,
                str_Parametros = $"{veiculo}.ID, {veiculo}.Veiculo, {veiculo}.Tipo, {veiculo}.Marca, {veiculo}.Placa, {veiculo}.Cor_Predominante, {cliente}.Nome, {cliente}.Telefone, {veiculo}.Ano_Fabricacao, {veiculo}.Combustivel, {veiculo}.Chassi, {veiculo}.Observacoes_Gerais",
                str_Parametro_Ordenador = $"{veiculo}.ID",
                str_On_Join = $"{veiculo}.ID_Responsavel = {cliente}.ID"
            };
            if (!string.IsNullOrWhiteSpace(pesquisa))
                dtb_consulta.str_Condicao = $"{veiculo}.Veiculo LIKE '%{pesquisa}%' OR {cliente}.Apelido LIKE '%{pesquisa}%' OR {cliente}.Nome LIKE '%{pesquisa}%'";

            return dtb_consulta;
        }
        // VALIDACOES [TST]
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Prencher(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            dgv_dataGrid.DataSource = dt_table;
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Nomear_DataGrid(dgv_dataGrid);
        }
        // OPERACOES
        private void Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.id_veiculo = int.Parse(dgv_veiculos.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
        private void Limpar()
        {
            txt_pesquisa.Text = string.Empty;
            this.id_veiculo = 0;
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Veículo";
            dgv_dataGrid.Columns[2].HeaderText = "Tipo";
            dgv_dataGrid.Columns[3].HeaderText = "Marca";
            dgv_dataGrid.Columns[4].HeaderText = "Placa";
            dgv_dataGrid.Columns[5].HeaderText = "Cor";
            dgv_dataGrid.Columns[6].HeaderText = "Responsável";
            dgv_dataGrid.Columns[7].HeaderText = "Contato";
            dgv_dataGrid.Columns[8].HeaderText = "Ano Fab.";
            dgv_dataGrid.Columns[9].HeaderText = "Combustível";
            dgv_dataGrid.Columns[10].HeaderText = "Chassi";
            dgv_dataGrid.Columns[11].HeaderText = "Observações";
        }
        // DataGridView
        private void dgv_veiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_ID(e);
            if (Validar_Identificador(this.id_veiculo))
            {
                new OPC_Veiculo(this.id_veiculo).ShowDialog();
                Prencher(dgv_veiculos, Consulta_Veiculo(""));
                Limpar();
            }
        }
        // TextBox
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Prencher(dgv_veiculos, Consulta_Veiculo(txt_pesquisa.Text));
        // Buttons
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_novo_veiculo_Click(object sender, EventArgs e)
        {
            new Frm_Cad_Veiculo().ShowDialog();
            Prencher(dgv_veiculos, Consulta_Veiculo(""));
            Limpar();
        }

        private void Frm_Veiculo_Load(object sender, EventArgs e) => Prencher(dgv_veiculos, Consulta_Veiculo(""));
    }
}
