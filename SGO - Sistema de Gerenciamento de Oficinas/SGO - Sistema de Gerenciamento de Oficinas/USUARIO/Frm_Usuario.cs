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
using TST;
using BLL;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Usuario : MetroForm
    {
        public Frm_Usuario()
        {
            InitializeComponent();
        }
        int id_usuario = 0;
        // Modelos >> DTO
        private DTB_Consulta Consulta_Usuario(string pesquisa)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Usuario;
            dtb_consulta.str_Parametros = "ID, Nome, User_Login";
            dtb_consulta.str_Parametro_Ordenador = "Nome";
            if (!(string.IsNullOrWhiteSpace(pesquisa)))
                dtb_consulta.str_Condicao = $"Nome LIKE '%{pesquisa}%' OR User_Login LIKE '%{pesquisa}%'";

            return dtb_consulta;
        }
        // Validacoes >> TST
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // Operacoes >> BLL
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta)
        {
            if (Validar_Consulta(dtb_consulta))
                return new Consultas().Consultar(dtb_consulta);
            else
                return null;
        }
        // Operacoes
        private void Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.id_usuario = int.Parse(dgv_usuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
        private void Prencher_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                dgv_dataGrid.DataSource = dt_table;
                dgv_dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                Nomear_DataGrid(dgv_dataGrid);
            }
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Nome";
                dgv_dataGrid.Columns[2].HeaderText = "Login";
            }
        }
        // Buttons
        private void btn_novo_usuario_Click(object sender, EventArgs e)
        {
            new Frm_Cad_Usuario().ShowDialog();
            Prencher_DataGrid(dgv_usuarios, Consulta_Usuario(""));
        }
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // Load
        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            Prencher_DataGrid(dgv_usuarios, Consulta_Usuario(""));
        }
        // DataGrid
        private void dgv_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_ID(e);
            new OPC_Usuario(this.id_usuario).ShowDialog();
            Prencher_DataGrid(dgv_usuarios, Consulta_Usuario(""));
        }
    }
}
