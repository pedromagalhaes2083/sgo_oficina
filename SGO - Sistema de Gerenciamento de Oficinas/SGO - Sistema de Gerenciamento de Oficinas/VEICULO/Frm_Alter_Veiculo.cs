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
    public partial class Frm_Alter_Veiculo : MetroForm
    {
        public Frm_Alter_Veiculo(int id)
        {
            InitializeComponent();
            this.id_veiculo = id;
        }
        int id_veiculo = 0;
        // Modelos 
        private DTO_Veiculo Veiculo()
        {
            DTO_Veiculo dto_veiculo = new DTO_Veiculo();
            dto_veiculo.int_ID = this.id_veiculo;
            dto_veiculo.int_Ano_Fabricacao = int.Parse(txt_ano_fab.Text);
            dto_veiculo.str_Chassi = txt_chassi.Text;
            dto_veiculo.str_Cor_Predominante = txt_cor.Text;
            dto_veiculo.str_Marca = cbx_marca.Text;
            dto_veiculo.str_Observacoes_Gerais = txt_observacoes.Text;
            dto_veiculo.str_Placa = txt_placa.Text;
            dto_veiculo.str_Tipo = cbx_tipo.Text;
            dto_veiculo.str_Veiculo = txt_nome.Text;
            dto_veiculo.str_Combustivel = cbx_combustivel.Text;

            return dto_veiculo;
        }
        private DTB_Consulta Consulta_Veiculo(int id_veiculo)
        {
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = veiculo,
                str_Tabela_Secundaria = cliente,
                str_Parametros = $"{veiculo}.ID, {veiculo}.Veiculo, {veiculo}.Tipo, {veiculo}.Marca, {veiculo}.Placa, {veiculo}.Cor_Predominante, {cliente}.Nome, {cliente}.Telefone, {veiculo}.Ano_Fabricacao, {veiculo}.Combustivel, {veiculo}.Chassi, {veiculo}.Observacoes_Gerais",
                str_Parametro_Ordenador = $"{veiculo}.ID",
                str_On_Join = $"{veiculo}.ID_Responsavel = {cliente}.ID",
                str_Condicao = $"{veiculo}.ID = {id_veiculo}"
            };

            return dtb_consulta;
        }
        // Validacoes
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Veiculo(DTO_Veiculo dto_veiculo) => TST_Veiculo.Validar_Modelo(dto_veiculo);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        // Operacoes >> BLL
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Alterar_Veiculo(DTO_Veiculo dto_veiculo) => new Veiculo().Fpu_Update(dto_veiculo);
        // Operacoes
        private void Alterar(DTO_Veiculo dto_veiculo)
        {
            if (Validar_Veiculo(dto_veiculo))
            {
                Alterar_Veiculo(dto_veiculo);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Prencher(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                txt_ano_fab.Text = Retornar_String(dt_table, "Ano_Fabricacao");
                txt_nome.Text = Retornar_String(dt_table, "Veiculo");
                txt_chassi.Text = Retornar_String(dt_table, "Chassi");
                txt_observacoes.Text = Retornar_String(dt_table, "Observacoes_gerais");
                txt_placa.Text = Retornar_String(dt_table, "Placa");
                txt_cor.Text = Retornar_String(dt_table, "Cor_Predominante");
                txt_responsavel.Text = Retornar_String(dt_table, "Nome");
                cbx_tipo.SelectedIndex = cbx_tipo.FindStringExact(Retornar_String(dt_table, "Tipo"));
                cbx_marca.SelectedIndex = cbx_marca.FindStringExact(Retornar_String(dt_table, "Marca"));
                cbx_combustivel.SelectedIndex = cbx_combustivel.FindStringExact(Retornar_String(dt_table, "Combustivel"));
            }
            else
                this.Close();
        }
        private void Prencher_ComboBox()
        {
            if (cbx_tipo.SelectedIndex == 0)
                cbx_marca.DataSource = new Listas_Marcas().Lista_Motos();
            else if (cbx_tipo.SelectedIndex == 1)
                cbx_marca.DataSource = new Listas_Marcas().Lista_Carros();
            else
                cbx_marca.Text = "N/A";
        }// ComboBox
        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e) => Prencher_ComboBox();
        // Load
        private void Frm_Alter_Veiculo_Load(object sender, EventArgs e) => Prencher(Consulta_Veiculo(this.id_veiculo));
        // Buttons
        private void btn_editar_Click(object sender, EventArgs e) => Alterar(Veiculo());
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
    }
}
