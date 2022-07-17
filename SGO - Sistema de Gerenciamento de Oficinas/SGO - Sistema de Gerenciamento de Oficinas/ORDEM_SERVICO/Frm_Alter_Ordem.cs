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
    public partial class Frm_Alter_Ordem : MetroForm
    {
        public Frm_Alter_Ordem(int id)
        {
            InitializeComponent();
            this.id_ordem = id;
        }
        int id_ordem = 0;
        // LOAD
        private void Frm_Alter_Ordem_Load(object sender, EventArgs e) => Prencher_Ordem(this.id_ordem);
        #region MODELO [DTO]
        private DTO_Ordem_Servico Ordem_Servico()
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico
            {
                int_ID = this.id_ordem,
                str_Observacoes_Avaria = txt_obs_avaria.Text,
                str_Observacoes_Cliente = txt_obs_cliente.Text,
                str_Combustivel = cbx_combustivel.Text,
                str_Status = DTC_Status_Ordem.Aberta,
                dec_Orcamento = 0,
                flt_Tempo_Estimado = 0,
                dte_Abertura = DateTime.Now,
                str_Nota = txt_nota.Text
            };

            return dto_ordem;
        }
        private DTB_Consulta Consulta_Ordem(int id_ordem)
        {
            string ordem = DTB_Tabelas.Ordem_Servico;
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;

            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Sql_Command = $"SELECT {ordem}.ID, {cliente}.Nome, {veiculo}.Veiculo , {veiculo}.Placa ,{ordem}.Combustivel,  {ordem}.Orcamento,  CAST( {ordem}.Tempo_Estimado AS DECIMAL(18, 2)), {ordem}.Observacoes_Avaria, {ordem}.Observacoes_Cliente, {ordem}.Nota, {veiculo}.Ano_Fabricacao, {veiculo}.Marca, {veiculo }.Cor_Predominante FROM {ordem} INNER JOIN {veiculo} ON {ordem}.ID_Veiculo = {veiculo}.ID INNER JOIN {cliente} ON {ordem}.ID_Responsavel = {cliente}.ID  WHERE {ordem}.ID = {id_ordem}"

            };

            return dtb_consulta;
        }
        private DTB_Consulta Consulta_Servico(string pesquisa)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Servico;
            dtb_consulta.str_Parametros = "ID, Nome, Preco, Tempo";
            dtb_consulta.str_Parametro_Ordenador = "ID";
            if (!(string.IsNullOrWhiteSpace(pesquisa)))
                dtb_consulta.str_Condicao = $"Nome like '%{pesquisa}%'";

            return dtb_consulta;
        }
        private DTB_Consulta Consulta_Servico_Pendente(int id_ordem, int id_servico)
        {
            string pendente = DTB_Tabelas.Servico_Pendente;
            string servico = DTB_Tabelas.Servico;
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = pendente,
                str_Tabela_Secundaria = servico,
                str_Parametros = $"{pendente}.ID_Servico, {pendente}.Status_Servico, {servico}.Nome, {servico}.Preco, {servico}.Tempo",
                str_Parametro_Ordenador = $"{pendente}.ID_Servico",
                str_On_Join = $"{servico}.ID = {pendente}.ID_Servico",
            };
            if (id_servico > 0)
                dtb_consulta.str_Condicao = $"{pendente}.ID_Ordem = {id_ordem} AND ID_Servico = {id_servico}";
            else
                dtb_consulta.str_Condicao = $"{pendente}.ID_Ordem = {id_ordem}";

            return dtb_consulta;
        }
        private DTO_Ordem_Servico Ordem_Orcamento(DataGridViewCellEventArgs e)
        {
            float orc = float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) > 60 ? float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) / 60 : float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) / 100;
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = this.id_ordem,
                dec_Orcamento = Retornar_Decimal(dgv_servicos, "Preco", e),
                flt_Tempo_Estimado = (float)Math.Round(orc, 2),
                str_Nota = string.Empty,
                dec_Total_Quitado = 0
            };

            return dto_ordem;
        }
        private DTO_Servico_Pendente Servico_Cancelamento(DataGridViewCellEventArgs e)
        {
            DTO_Servico_Pendente dto_servico = new DTO_Servico_Pendente()
            {
                int_ID_Ordem = id_ordem,
                int_ID_Servico = int.Parse(Retornar_String(dgv_servicos, "ID", e)),
                str_Status = DTC__Status_Servico.Cancelado,
                str_Observacoes = string.Empty
            };
            return dto_servico;
        }
        private DTO_Servico_Pendente Servico_Insercao(DataGridViewCellEventArgs e)
        {
            DTO_Servico_Pendente dto_servico = new DTO_Servico_Pendente
            {
                int_ID_Servico = int.Parse(Retornar_String(dgv_servicos, "ID", e)),
                int_ID_Ordem = this.id_ordem,
                str_Status = DTC__Status_Servico.Aguardando,
                str_Observacoes = string.Empty
            };
            return dto_servico;
        }
        #endregion
        #region VALIDACOES [TST]
        private bool Validar_Servico(DTO_Servico_Pendente dto_servico) => TST_Servico_Pendente.Validar_Modelo(dto_servico);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_Ordem(DTO_Ordem_Servico dto_ordem, string key) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, key);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        #endregion
        #region OPERACOES [RETORNOS]
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private string Retornar_String(DataGridView dgv_dataGrid, string Paramentro, DataGridViewCellEventArgs e) => e.RowIndex >= 0 ? dgv_dataGrid.Rows[e.RowIndex].Cells[Paramentro].Value.ToString() : string.Empty;
        private int Retornar_Inteiro(DataTable dt_table, string parametro) => int.Parse(dt_table.Rows[0][parametro].ToString());
        private decimal Retornar_Decimal(DataGridView dgv_dataGrid, string parametro, DataGridViewCellEventArgs e) => e.RowIndex >= 0 ? decimal.Parse(dgv_dataGrid.Rows[e.RowIndex].Cells[parametro].Value.ToString()) : 0;
        #endregion
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta) => new Consultas().Consultar(dtb_consulta);
        #region ORDEM
        private void Alterar_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Ordem(dto_ordem, "u"))
            {
                new Ordem_Servico().Fpu_Update_Ordem(dto_ordem);
                new Status_Ordem().Gerenciar_Status(this.id_ordem);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);

        }
        private void Alterar_Orcamento(DTO_Ordem_Servico dto_ordem, string opr)
        {
            if (Validar_Ordem(dto_ordem, "o"))
                new Ordem_Servico().Fpu_Update_Orcamento(dto_ordem, opr);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        #endregion
        #region SERVICO
        private void Adicionar_Servico(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt_table = Consultar(Consulta_Servico_Pendente(id_ordem, int.Parse(Retornar_String(dgv_servicos, "ID", e))));
                if (!Validar_DataTable(dt_table))
                {
                    if (Validar_Servico(Servico_Insercao(e)))
                    {
                        new Servico_Pendente().Fpu_Insert(Servico_Insercao(e));
                        Alterar_Orcamento(Ordem_Orcamento(e), "som");
                        new Status_Ordem().Gerenciar_Status(this.id_ordem);
                    }
                    else
                        MessageBox.Show(USER_MESSAGE.Ordem_NEncontrada);
                }
            }
        }
        private void Cancelar_Servico(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt_table = Consultar(Consulta_Servico_Pendente(id_ordem, 0));
                if (Validar_DataTable(dt_table))
                {
                    new Servico_Pendente().Fpu_Update_Status(Servico_Cancelamento(e));
                    Alterar_Orcamento(Ordem_Orcamento(e), "sub");
                    new Status_Ordem().Gerenciar_Status(this.id_ordem);
                }
            }
        }
        #endregion
        // OPERACOES 
        private void Prencher_DataGrid(DataGridView dgv_dataGrid, DTB_Consulta dtb_consulta)
        {
            dgv_dataGrid.DataSource = Consultar(dtb_consulta);
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #region [SERVICOS]
        private void Prencher_Servicos(DTB_Consulta dtb_consulta)
        {
            Prencher_DataGrid(dgv_servicos, Consulta_Servico(""));
            Nomear_Servico(dgv_servicos);
        }
        private void Prencher_Servicos_Pendentes(DTB_Consulta dtb_consulta)
        {
            Prencher_DataGrid(dgv_servicos_fazer, dtb_consulta);
            Nomear_Servico_Pendete(dgv_servicos_fazer);
        }
        private void Nomear_Servico(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Nome";
                dgv_dataGrid.Columns[2].HeaderText = "Preço";
                dgv_dataGrid.Columns[3].HeaderText = "Tempo Estimado (Mins)";
            }
        }
        private void Nomear_Servico_Pendete(DataGridView dgv_dataGrid)
        {
            if (Validar_DataGrid(dgv_dataGrid))
            {
                dgv_dataGrid.Columns[0].HeaderText = "ID";
                dgv_dataGrid.Columns[1].HeaderText = "Status";
                dgv_dataGrid.Columns[2].HeaderText = "Nome";
                dgv_dataGrid.Columns[3].HeaderText = "Preço";
                dgv_dataGrid.Columns[4].HeaderText = "Tempo Estimado (Mins)";
            }
        }
        #endregion
        private void Prencher_Ordem(int id_ordem)
        {
            DataTable dt_table = Consultar(Consulta_Ordem(id_ordem));
            if (Validar_DataTable(dt_table))
            {
                txt_responsavel.Text = Retornar_String(dt_table, "Nome");
                txt_placa.Text = Retornar_String(dt_table, "Placa");
                txt_veiculo.Text = Retornar_String(dt_table, "Veiculo");
                txt_ano_fab.Text = Retornar_String(dt_table, "Ano_Fabricacao");
                txt_cor.Text = Retornar_String(dt_table, "Cor_Predominante");
                txt_marca.Text = Retornar_String(dt_table, "Marca");
                txt_nota.Text = Retornar_String(dt_table, "Nota");
                txt_obs_avaria.Text = Retornar_String(dt_table, "Observacoes_Avaria");
                txt_obs_cliente.Text = Retornar_String(dt_table, "Observacoes_Cliente");
                cbx_combustivel.SelectedIndex = cbx_combustivel.FindStringExact(Retornar_String(dt_table, "Combustivel"));
                cbx_combustivel.Enabled = false;
            }
            Prencher_Servicos(Consulta_Servico(""));
            Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem,0));
        }
        // TABCONTROL
        private void tbc_Controle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbc_Controle.SelectedTab == tab_servico)
                btn_editar.Enabled = false;
            else
                btn_editar.Enabled = true;
        }
        // BUTTONS
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // DATAGRID
        private void dgv_servicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Adicionar_Servico(e);
            Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
        }
        private void dgv_servicos_fazer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cancelar_Servico(e);
            Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
        }
        // TEXTBOX
        private void txt_pesquisa_servico_TextChanged(object sender, EventArgs e) => Prencher_Servicos(Consulta_Servico(txt_pesquisa_servico.Text));

        private void btn_editar_Click(object sender, EventArgs e) => Alterar_Ordem(Ordem_Servico());
    }
}
