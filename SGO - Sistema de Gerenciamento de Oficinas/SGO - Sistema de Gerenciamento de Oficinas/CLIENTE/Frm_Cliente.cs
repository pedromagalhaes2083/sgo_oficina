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
    public partial class Frm_Cliente : MetroForm
    {
        public Frm_Cliente()
        {
            InitializeComponent();
        }
        int id_cliente = 0;
        // Modelo
        private DTB_Consulta Consulta_Cliente(string nome)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Tabela = DTB_Tabelas.Cliente,
                str_Parametros = "ID, Status_Cliente, Nome, Apelido, Telefone, Endereco, Observacoes",
                str_Parametro_Ordenador = "ID"
            };
            if (!(string.IsNullOrWhiteSpace(nome)))
                dtb_consulta.str_Condicao = $" Nome LIKE '%{nome}%' OR Apelido LIKE '%{nome}%'";

            return dtb_consulta;
        }
        // Validacoes
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        // Operacoes
        private void Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.id_cliente = int.Parse(dgv_clientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
        private void Prencher_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                dgv_dataGrid.DataSource = dt_table;
                Nomear_DataGrid(dgv_dataGrid);
                dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Consultar);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Status";
                dgv_dataGrid.Columns[2].HeaderText = "Nome";
                dgv_dataGrid.Columns[3].HeaderText = "Apelido";
                dgv_dataGrid.Columns[4].HeaderText = "Telefone";
                dgv_dataGrid.Columns[5].HeaderText = "Endereço";
                dgv_dataGrid.Columns[6].HeaderText = "Observaçoes";
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Prencher);
        }
        private void Limpar()
        {
            txt_pesquisa.Text = string.Empty;
            this.id_cliente = 0;
        }
        // Buttons
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_novo_cliente_Click(object sender, EventArgs e)
        {
            new Frm_Cad_Cliente().ShowDialog();
            Prencher_DataGrid(dgv_clientes, Consulta_Cliente(""));
        }
        // TextBox
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Prencher_DataGrid(dgv_clientes, Consulta_Cliente(txt_pesquisa.Text));
        // DataGrid
        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_ID(e);
            if (Validar_Identificador(this.id_cliente))
            {
                _ = new OPC_Cliente(this.id_cliente).ShowDialog();
                Prencher_DataGrid(dgv_clientes, Consulta_Cliente(""));
                Limpar();
            }
        }
        // Load
        private void Frm_Cliente_Load(object sender, EventArgs e) => Prencher_DataGrid(dgv_clientes, Consulta_Cliente(""));
    }
}
