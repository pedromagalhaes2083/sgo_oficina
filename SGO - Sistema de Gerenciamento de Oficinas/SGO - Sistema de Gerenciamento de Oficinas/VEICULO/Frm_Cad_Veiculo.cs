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
    public partial class Frm_Cad_Veiculo : MetroForm
    {
        public Frm_Cad_Veiculo()
        {
            InitializeComponent();
        }
        int id_responsavel = 0;
        // Load
        private void Frm_Cad_Veiculo_Load(object sender, EventArgs e)
        {
            Prencher_ComboBox();
            Prencher_DataGrid(dgv_clientes, "");
        }
        // Modelos
        private DTB_Consulta Consulta_Clientes(string nome)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Tabela = DTB_Tabelas.Cliente,
                str_Parametros = "ID, Nome, Endereco",
                str_Parametro_Ordenador = "ID"
            };
            if (string.IsNullOrWhiteSpace(nome))
                dtb_consulta.str_Condicao = $"Nome like '%{nome}%' or Apelido like '%{nome}%' ";

            return dtb_consulta;
        }
        private DTO_Veiculo Modelo_Veiculo()
        {
            int ano;
            DTO_Veiculo dto_veiculo = new DTO_Veiculo
            {
                int_Ano_Fabricacao = int.TryParse(txt_ano_fab.Text, out ano) ? ano : ano,
                str_Chassi = txt_chassi.Text,
                str_Cor_Predominante = txt_cor.Text,
                str_Marca = cbx_marca.Text,
                str_Observacoes_Gerais = txt_observacoes.Text,
                str_Placa = txt_placa.Text,
                str_Tipo = cbx_tipo.Text,
                str_Veiculo = txt_nome.Text,
                int_ID_Responsavel = this.id_responsavel,
                str_Combustivel = cbx_combustivel.Text
            };

            return dto_veiculo;
        }
        // Validacoes >> TST
        private bool Validar_Veiculo(DTO_Veiculo dto_veiculo) => TST_Veiculo.Validar_Modelo(dto_veiculo);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        // OPERACOES [BLL]
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => new Consultas().Consultar(dtb_consulta);
        private void Cadastrar_Veiculo(DTO_Veiculo dto_veiculo) => new Veiculo().Fpu_Insert(dto_veiculo);
        // OPERACOES
        private void Capturar_Grid(TextBox txt_textbox, string parametro, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_textbox.Text = dgv_clientes.Rows[e.RowIndex].Cells[parametro].Value.ToString();
                this.id_responsavel = int.Parse(dgv_clientes.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
        }
        private void Prencher_ComboBox()
        {
            if (cbx_tipo.SelectedIndex == 0)
                cbx_marca.DataSource = new Listas_Marcas().Lista_Motos();
            else if (cbx_tipo.SelectedIndex == 1)
                cbx_marca.DataSource = new Listas_Marcas().Lista_Carros();
            else
                cbx_marca.Text = "N/A";
        }
        private void Limpar()
        {
            txt_ano_fab.Text = string.Empty;
            txt_chassi.Text = string.Empty;
            txt_cor.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_observacoes.Text = string.Empty;
            txt_pesquisa.Text = string.Empty;
            txt_placa.Text = string.Empty;
            txt_responsavel.Text = string.Empty;
            chk_usa_placa.Checked = true;
            this.id_responsavel = 0;
        }
        private void Prencher_DataGrid(DataGridView dgv_dataGrid, string nome)
        {
            DataTable dt_table = Consultar_Banco(Consulta_Clientes(nome));
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
                dgv_dataGrid.Columns[1].HeaderText = "Nome";
                dgv_dataGrid.Columns[2].HeaderText = "Endereço";
            }
        }
        private void Cadastrar(DTO_Veiculo dto_veiculo)
        {
            if (Validar_Veiculo(dto_veiculo))
            {
                Cadastrar_Veiculo(dto_veiculo);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                Limpar();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // CHECKBOX
        private void chk_usa_placa_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_usa_placa.Checked is true)
            {
                txt_placa.Text = string.Empty;
                txt_placa.Enabled = true;
            }
            else
            {
                txt_placa.Text = "N/A";
                txt_placa.Enabled = false;
            }
        }
        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e) => Prencher_ComboBox();
        // TABCONTROL
        private void tbc_Controle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc_Controle.SelectedIndex == 1 && this.id_responsavel <= 0)
            {
                MessageBox.Show(USER_MESSAGE.Escolha_Responsavel);
                tbc_Controle.SelectedIndex = 0;
            }
        }
        // DATAGRID
        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Capturar_Grid(txt_responsavel, "Nome", e);
        // BUTTON
        private void btn_cadastrar_Click(object sender, EventArgs e) => Cadastrar(Modelo_Veiculo());
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
    }
}
