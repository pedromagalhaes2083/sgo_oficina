using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using DTO;
using BLL;
using TST;
using System.Windows.Forms;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Abrir_Ordem_Servico : MetroForm
    {
        public Frm_Abrir_Ordem_Servico() => InitializeComponent();
        // VARIVEIS
        int id_ordem = 0;
        int id_veiculo = 0;
        int id_responsavel = 0;
        // LOAD
        private void Frm_Abrir_Ordem_Servico_Load(object sender, EventArgs e)
        {
            Prencher_Veiculos(Consulta_Veiculo("", 0));
            Prencher_Servicos(Consulta_Servico(""));
        }
        #region MODELO [DTO]
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
        private DTB_Consulta Consulta_Veiculo(string pesquisa, int id_veiculo)
        {
            string veiculo = DTB_Tabelas.Veiculo;
            string cliente = DTB_Tabelas.Cliente;
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = veiculo,
                str_Tabela_Secundaria = cliente,
                str_Parametros = $"{veiculo}.ID, {veiculo}.Veiculo, {veiculo}.Tipo, {veiculo}.Marca, {veiculo}.Placa, {veiculo}.Cor_Predominante, {veiculo}.ID_Responsavel, {cliente}.Nome, {cliente}.Telefone, {veiculo}.Ano_Fabricacao, {veiculo}.Combustivel, {veiculo}.Observacoes_Gerais",
                str_Parametro_Ordenador = $"{veiculo}.ID",
                str_On_Join = $"{veiculo}.ID_Responsavel = {cliente}.ID"
            };
            if (id_veiculo > 0)
                dtb_consulta.str_Condicao = $"{veiculo}.ID = {id_veiculo}";
            else if (!string.IsNullOrWhiteSpace(pesquisa))
                dtb_consulta.str_Condicao = $"{veiculo}.Veiculo LIKE '%{pesquisa}%' OR {cliente}.Nome LIKE '%{pesquisa}%' OR {cliente}.Apelido LIKE '%{pesquisa}%'";

            return dtb_consulta;
        }
        private DTB_Consulta Consulta_Ordem(int id_veiculo)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta
            {
                str_Tabela = DTB_Tabelas.Ordem_Servico,
                str_Parametros = "ID, Status_Ordem, Nota, Combustivel, Observacoes_Cliente, Observacoes_Avaria",
                str_Parametro_Ordenador = "ID",
                str_Condicao = $"ID_Veiculo = {id_veiculo} AND Status_Ordem lIKE '%{DTC_Status_Ordem.Aberta}%'"
            };
            return dtb_consulta;
        }
        private DTO_Ordem_Servico Ordem_Servico()
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico
            {
                int_ID_Veiculo = this.id_veiculo,
                str_Observacoes_Avaria = txt_obs_avaria.Text,
                str_Observacoes_Cliente = txt_obs_cliente.Text,
                int_ID_Responsavel = this.id_responsavel,
                str_Combustivel = cbx_combustivel.Text,
                str_Status = DTC_Status_Ordem.Aberta,
                dec_Orcamento = 0,
                flt_Tempo_Estimado = 0,
                dte_Abertura = DateTime.Now,
                str_Nota = txt_nota.Text
            };

            return dto_ordem;
        }
        private DTO_Ordem_Servico Ordem_Nota()
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = this.id_ordem,
                str_Nota = txt_nota.Text
            };

            return dto_ordem;
        }
        private DTO_Ordem_Servico Ordem_Orcamento(DataGridViewCellEventArgs e)
        {
            float tpm = float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) >= 60 ? float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) / 60 : float.Parse(Retornar_String(dgv_servicos, "Tempo", e)) / 100;

            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = this.id_ordem,
                dec_Orcamento = Retornar_Decimal(dgv_servicos, "Preco", e),
                flt_Tempo_Estimado = (float)Math.Round(tpm, 2),
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
                str_Observacoes = String.Empty
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
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_Ordem(DTO_Ordem_Servico dto_ordem, string key) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, key);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_DataGrid(DataGridView dgv_dataGrid) => TST_DataGrid.Validar_Modelo(dgv_dataGrid);
        #endregion
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        #region ORDEM
        private void Ordem_Abertura(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Ordem(dto_ordem, "a"))
            {
                new Ordem_Servico().Fpu_Insert(dto_ordem);
                Confirmar_Abertura(this.id_veiculo);
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void Alterar_Nota(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Ordem(dto_ordem, "n"))
            {
                new Ordem_Servico().Fpu_Update_Nota(dto_ordem);
                MessageBox.Show(USER_MESSAGE.Sucesso);
            }
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
                    new Operacoes_Ordem_Servico().Adicionar_Servico(Servico_Insercao(e), Ordem_Orcamento(e));
            }
        }
        private void Cancelar_Servico(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt_table = Consultar(Consulta_Servico_Pendente(id_ordem, 0));
                if (Validar_DataTable(dt_table))
                    new Operacoes_Ordem_Servico().Cancelar_Servico(Servico_Cancelamento(e), Ordem_Orcamento(e));
            }
        }
        #endregion
        #region OPERACOES [RETORNOS]
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private string Retornar_String(DataGridView dgv_dataGrid, string Paramentro, DataGridViewCellEventArgs e) => e.RowIndex >= 0 ? dgv_dataGrid.Rows[e.RowIndex].Cells[Paramentro].Value.ToString() : string.Empty;
        private int Retornar_Inteiro(DataTable dt_table, string parametro) => int.Parse(dt_table.Rows[0][parametro].ToString());
        private decimal Retornar_Decimal(DataGridView dgv_dataGrid, string parametro, DataGridViewCellEventArgs e) => e.RowIndex >= 0 ? decimal.Parse(dgv_dataGrid.Rows[e.RowIndex].Cells[parametro].Value.ToString()) : 0;
        #endregion
        // OPERACOES 
        private void Confirmar_Abertura(int id_veiculo)
        {
            DataTable dt_table = Consultar(Consulta_Ordem(id_veiculo));
            if (Validar_DataTable(dt_table))
            {
                this.id_ordem = Retornar_Inteiro(dt_table, "ID");
                Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
                if (Retornar_String(dt_table, "Status_Ordem").Equals(DTC_Status_Ordem.Aberta))
                {
                    btn_abrir_ordem.Enabled = false;
                    MessageBox.Show(USER_MESSAGE.Sucesso);
                }
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Operacao);
        }
        private void Verificar_Ordem(int id_veiculo)
        {
            DataTable dt_table = Consultar(Consulta_Ordem(id_veiculo));
            if (Validar_DataTable(dt_table))
            {
                txt_nota.Text = Retornar_String(dt_table, "Nota");
                btn_abrir_ordem.Enabled = !Validar_DataTable(dt_table);
                this.id_ordem = Retornar_Inteiro(dt_table, "ID");
                Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
                cbx_combustivel.SelectedIndex = cbx_combustivel.FindStringExact(Retornar_String(dt_table, "Combustivel"));
                cbx_combustivel.Enabled = false;
                txt_obs_avaria.Text = Retornar_String(dt_table, "Observacoes_Avaria");
                txt_obs_cliente.Text = Retornar_String(dt_table, "Observacoes_Cliente");
                if (Retornar_String(dt_table, "Status_Ordem").Equals(DTC_Status_Ordem.Aberta))
                {
                    txt_obs_cliente.ReadOnly = true;
                    txt_obs_avaria.ReadOnly = true;
                    btn_abrir_ordem.Enabled = false;
                    MessageBox.Show(USER_MESSAGE.Ordem_Existente);
                }
            }
            else
            {
                txt_obs_avaria.ReadOnly = false;
                txt_obs_cliente.ReadOnly = false;
                txt_obs_avaria.Text = string.Empty;
                txt_obs_cliente.Text = string.Empty;
                cbx_combustivel.Enabled = true;
                btn_abrir_ordem.Enabled = true;
                dgv_servicos_fazer.DataSource = null;
                this.id_ordem = 0;
            }
        }
        private void Popular_DataGrid(DTB_Consulta dtb_consulta, DataGridView dgv_dataGrid)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            dgv_dataGrid.DataSource = dt_table;
            dgv_dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        // PRENCHIMENTOS
        private void Prencher_Servicos(DTB_Consulta dtb_consulta)
        {
            Popular_DataGrid(dtb_consulta, dgv_servicos);
            Nomear_Servico(dgv_servicos);
        }
        private void Prencher_Servicos_Pendentes(DTB_Consulta dtb_consulta)
        {
            Popular_DataGrid(dtb_consulta, dgv_servicos_fazer);
            Nomear_Servico_Pendete(dgv_servicos_fazer);
        }
        private void Prencher_Veiculos(DTB_Consulta dtb_consulta)
        {
            Popular_DataGrid(dtb_consulta, dgv_veiculos);
            Nomear_Veiculos(dgv_veiculos);
        }
        private void Prencher_Ordem(DataGridViewCellEventArgs e)
        {
            txt_responsavel.Text = Retornar_String(dgv_veiculos, "Nome", e);
            txt_placa.Text = Retornar_String(dgv_veiculos, "Placa", e);
            txt_veiculo.Text = Retornar_String(dgv_veiculos, "Veiculo", e);
            if (e.RowIndex >= 0)
            {
                this.id_veiculo = int.Parse(Retornar_String(dgv_veiculos, "ID", e));
                this.id_responsavel = int.Parse(Retornar_String(dgv_veiculos, "ID_Responsavel", e));
                txt_obs_avaria.ReadOnly = !(id_veiculo > 0);
                txt_obs_cliente.ReadOnly = !(id_veiculo > 0);

            }
            DataTable dt_table = Consultar(Consulta_Veiculo("", id_veiculo));
            if (Validar_DataTable(dt_table))
            {
                txt_marca.Text = Retornar_String(dt_table, "Marca");
                txt_ano_fab.Text = Retornar_String(dt_table, "Ano_Fabricacao");
                txt_cor.Text = Retornar_String(dt_table, "Cor_Predominante");
            }
        }
        // CONFIGURACAO - DATAGRID
        private void Nomear_Servico(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Nome";
            dgv_dataGrid.Columns[2].HeaderText = "Preço";
            dgv_dataGrid.Columns[3].HeaderText = "Tempo Estimado (Mins)";
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
        private void Nomear_Veiculos(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Veículo";
            dgv_dataGrid.Columns[2].HeaderText = "Tipo";
            dgv_dataGrid.Columns[3].HeaderText = "Placa";
            dgv_dataGrid.Columns[4].HeaderText = "Cor";
            dgv_dataGrid.Columns[5].HeaderText = "Chassi";
            dgv_dataGrid.Columns[6].HeaderText = "Ano Fab.";
            dgv_dataGrid.Columns[7].HeaderText = "Observações";
            dgv_dataGrid.Columns[8].HeaderText = "Marca";
            dgv_dataGrid.Columns[9].HeaderText = "Responsável";
            dgv_veiculos.Columns[10].HeaderText = "ID Resp.";
        }
        // DATAGRID
        private void dgv_servicos_fazer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cancelar_Servico(e);
            Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
        }
        private void dgv_servicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Adicionar_Servico(e);
            Prencher_Servicos_Pendentes(Consulta_Servico_Pendente(this.id_ordem, 0));
        }
        private void dgv_veiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Prencher_Ordem(e);
            Verificar_Ordem(id_veiculo);
            Controle_Abertura();
        }
        // TEXTBOX
        private void txt_pesquisa_veiculo_TextChanged(object sender, EventArgs e) => Prencher_Veiculos(Consulta_Veiculo(txt_pesquisa_veiculo.Text, 0));
        private void txt_pesquisa_servico_TextChanged(object sender, EventArgs e) => Prencher_Servicos(Consulta_Servico(txt_pesquisa_servico.Text));
        // BUTTON
        private void btn_abrir_ordem_Click(object sender, EventArgs e)
        {
            if (tbc_Controle.SelectedTab == tab_nota && this.id_ordem > 0)
                Alterar_Nota(Ordem_Nota());
            else
                Ordem_Abertura(Ordem_Servico());
        }
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // CONTROLE BUTTON [ABRIR ORDEM]
        private void Abertura_Lancamento()
        {
            btn_abrir_ordem.Enabled = true;
            if (this.id_ordem > 0)
            {
                btn_abrir_ordem.Text = "     Lançar";
                btn_abrir_ordem.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btn_abrir_ordem.Text = "Abrir Ordem";
                btn_abrir_ordem.TextAlign = ContentAlignment.MiddleRight;
            }
        }
        private void Controle_Abertura()
        {
            // TABCONTROL [FUNCAO]
            if (tbc_Controle.SelectedTab == tab_veiculo && this.id_veiculo > 0)
                Abertura_Lancamento();
            else if (tbc_Controle.SelectedTab == tab_ordem)
                Abertura_Lancamento();
            else if (tbc_Controle.SelectedTab == tab_nota)
                Abertura_Lancamento();
            else if (tbc_Controle.SelectedTab == tab_servico && this.id_ordem > 0)
            {
                btn_abrir_ordem.Enabled = false;
                btn_abrir_ordem.Text = "     Lançar";
                btn_abrir_ordem.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btn_abrir_ordem.Enabled = false;
                btn_abrir_ordem.Text = "Abrir Ordem";
                btn_abrir_ordem.TextAlign = ContentAlignment.MiddleRight;
            }
        }
        // TABCONTROL
        private void tbc_Controle_SelectedIndexChanged(object sender, EventArgs e) => Controle_Abertura();


    }
}