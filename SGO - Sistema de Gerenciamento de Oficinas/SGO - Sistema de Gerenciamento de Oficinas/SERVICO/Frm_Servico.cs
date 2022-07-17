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
    public partial class Frm_Servico : MetroForm
    {
        public Frm_Servico()
        {
            InitializeComponent();
        }
        int id_servico = 0;
        // MODELO [DTO]
        private DTB_Consulta Consulta_Servico(string pesquisa)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Servico;
            dtb_consulta.str_Parametros = "ID, Nome, Tempo, Preco, Observacoes";
            dtb_consulta.str_Parametro_Ordenador = "ID";
            if (!string.IsNullOrWhiteSpace(pesquisa))
                dtb_consulta.str_Condicao = $"Nome like '%{pesquisa}%'";

            return dtb_consulta;
        }
        // VALIDACOES [TST]
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta)
        {
            if (Validar_Consulta(dtb_consulta))
                return new Consultas().Consultar(dtb_consulta);
            else
                return null;
        }
        // OPERACOES
        private void Limpar()
        {
            txt_pesquisa.Text = string.Empty;
            this.id_servico = 0;
        }
        private void Prencher(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                dgv_dataGrid.DataSource = dt_table;
                dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Nomear_DataGrid(dgv_dataGrid);
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Consultar);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Nome";
                dgv_dataGrid.Columns[2].HeaderText = "Tempo (Mins)";
                dgv_dataGrid.Columns[3].HeaderText = "Preço";
                dgv_dataGrid.Columns[4].HeaderText = "Observações";
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Prencher);
        }
        private void Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                this.id_servico = int.Parse(dgv_servicos.Rows[e.RowIndex].Cells["ID"].Value.ToString());
        }
        // LOAD
        private void Frm_Servico_Load(object sender, EventArgs e) => Prencher(dgv_servicos, Consulta_Servico(""));
        // BUTTONS
        private void btn_novo_servico_Click(object sender, EventArgs e)
        {
            Frm_Cad_Servico frm_Cad_Servico = new Frm_Cad_Servico();
            frm_Cad_Servico.ShowDialog();
            Prencher(dgv_servicos, Consulta_Servico(""));
        }
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // DATAGRID
        private void dgv_servicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Get_ID(e);
            if (Validar_Identificador(this.id_servico))
            {
                _ = new OPC_Servico(this.id_servico).ShowDialog();
                Prencher(dgv_servicos, Consulta_Servico(""));
                Limpar();
            }
        }
        // TEXTBOX
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Prencher(dgv_servicos, Consulta_Servico(txt_pesquisa.Text));

        
    }
}
