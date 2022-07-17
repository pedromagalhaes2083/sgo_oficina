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
    public partial class Frm_Cad_Registro_Servico : MetroForm
    {
        public Frm_Cad_Registro_Servico()
        {
            InitializeComponent();
        }
        int id_cliente = 0;
        // LOAD
        private void Frm_Cad_Registro_Servico_Load(object sender, EventArgs e) => Prencher_DataGrid(Consulta_Cliente(""));
        // MODELO >> DTB
        private DTB_Consulta Consulta_Cliente(string str_pesquisa)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = DTB_Tabelas.Cliente,
                str_Parametros = "ID, Nome, Apelido, Endereco",
                str_Parametro_Ordenador = "Nome"
            };
            if (!string.IsNullOrWhiteSpace(str_pesquisa))
                dtb_consulta.str_Condicao = $"Nome LIKE '%{str_pesquisa}%'";

            return dtb_consulta;
        }
        private DTO_Registro_Servico Registro_Servico()
        {
            DTO_Registro_Servico dto_registro = new DTO_Registro_Servico()
            {
                str_Descricao = txt_descricao.Text,
                str_Observacao = txt_observacoes.Text,
                dec_Preco = decimal.Parse(mkt_valor.Text),
                int_ID_Cliente = this.id_cliente,
                dte_Data = dtp_data.Value.Date
            };

            return dto_registro;
        }
        // VALIDACOES >> TST
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_Registro(DTO_Registro_Servico dto_registro) => TST_Registro_Servico.Validar_Modelo(dto_registro);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // OPERACOES >> BLL 
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Cadastrar(DTO_Registro_Servico dto_registro) => new Registro_Servico().Fpu_Insert(dto_registro);
        // OPERACOES 
        private int Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                return int.Parse(dgv_clientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            else
                return 0;
        }
        private void Prencher_DataGrid(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                dgv_clientes.DataSource = dt_table;
                dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            Nomear_DataGrid(dgv_clientes);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Nome";
                dgv_dataGrid.Columns[2].HeaderText = "Apelido";
                dgv_dataGrid.Columns[3].HeaderText = "Endereço";
            }
        }
        private void Cadastrar_Registro(DTO_Registro_Servico dto_registro)
        {
            if (Validar_Registro(dto_registro))
            {
                Cadastrar(dto_registro);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                Limpar();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void Limpar()
        {
            txt_descricao.Text = string.Empty;
            txt_observacoes.Text = string.Empty;
            txt_pesquisa.Text = string.Empty;
            mkt_valor.Text = string.Empty;
            this.id_cliente = 0;
            tab_main.SelectedTab = tab_cliente;
        }
        // TABCONTROL
        private void tab_resgistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_main.SelectedTab == tab_registro && this.id_cliente <= 0)
            {
                _ = MessageBox.Show(USER_MESSAGE.Escolha_Responsavel);
                tab_main.SelectedTab = tab_cliente;
            }
        }
        // DATAGRID
        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e) => this.id_cliente = Get_ID(e);
        // BUTTON
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_cadastrar_Click(object sender, EventArgs e) => Cadastrar_Registro(Registro_Servico());
        // TEXTBOX
        private void txt_pesquisa_TextChanged(object sender, EventArgs e) => Prencher_DataGrid(Consulta_Cliente(txt_pesquisa.Text));
    }
}
