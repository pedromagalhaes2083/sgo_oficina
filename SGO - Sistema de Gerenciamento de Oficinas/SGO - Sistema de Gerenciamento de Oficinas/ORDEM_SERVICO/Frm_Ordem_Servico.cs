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
    public partial class Frm_Ordem_Servico : MetroForm
    {
        public Frm_Ordem_Servico(DTO_Ordem_Servico dt_ordem)
        {
            InitializeComponent();
            this.id_ordem = dt_ordem.int_ID;
        }
        int id_ordem = 0;
        int id_servico = 0;
        private void Frm_Ordem_Servico_Load(object sender, EventArgs e)
        {
            Prencher_Dados(this.id_ordem);
            Popular_DataGrid(Consulta_Servico(this.id_ordem));
        }
        // MODELOS [DTO]
        private DTO_Servico_Pendente Servico(int id_servico, int id_ordem, string status)
        {
            DTO_Servico_Pendente dto_servico = new DTO_Servico_Pendente()
            {
                int_ID_Ordem = id_ordem,
                int_ID_Servico = id_servico,
                str_Status = status
            };

            return dto_servico;
        }
        private DTO_Ordem_Servico Ordem(int id_ordem, float flt_tempo, decimal dec_orcamento)
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = id_ordem,
                flt_Tempo_Estimado = flt_tempo,
                dec_Orcamento = dec_orcamento
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
                str_Sql_Command = $"SELECT {ordem}.ID, {ordem}.Status_Ordem, {cliente}.Nome, {veiculo}.Veiculo , {veiculo}.Cor_Predominante, {veiculo}.Ano_Fabricacao, {veiculo}.Placa, {veiculo}.Marca ,{ordem}.Combustivel,  {ordem}.Orcamento,  {ordem}.Tempo_Estimado, {ordem}.Data_Abertura, {ordem}.Nota FROM {ordem} INNER JOIN {veiculo} ON {ordem}.ID_Veiculo = {veiculo}.ID INNER JOIN {cliente} ON {ordem}.ID_Responsavel = {cliente}.ID  WHERE {ordem}.ID = {id_ordem}"
            };

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
        // VALIDACOES [TST]
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_Servico(DTO_Servico_Pendente dto_servico) => TST_Servico_Pendente.Validar_Modelo(dto_servico);
        private bool Validar_Ordem(DTO_Ordem_Servico dto_ordem) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, "u");
        // OPERACOES [BLL]
        private DataTable Consultar_Banco(DTB_Consulta dtb_cosnulta) => new Consultas().Consultar(dtb_cosnulta);
        private void Alterar_Status(DTO_Servico_Pendente dto_servico)
        {
            if (Validar_Servico(dto_servico))
            {
                new Servico_Pendente().Fpu_Update_Status(dto_servico);
                Recalcular_Dados(this.id_ordem);
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
            this.id_servico = 0;
            Popular_DataGrid(Consulta_Servico(this.id_ordem));
            new Status_Ordem().Gerenciar_Status(this.id_ordem);
        }
        private void Atualizar_Valores(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Ordem(dto_ordem))
                new Ordem_Servico().Fpu_Update_TOrcamento(dto_ordem);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // OPERACOES 
        private void Recalcular_Dados(int id_ordem)
        {
            DataTable dt_table = Consultar_Banco(Consulta_Servico(id_ordem));
            decimal orcamento = 0;
            float tempo = 0;
            foreach (DataRow row in dt_table.Rows)
            {
                if (!row["Status_Servico"].ToString().Equals(DTC__Status_Servico.Cancelado))
                {
                    orcamento += decimal.Parse(row["Preco"].ToString());
                    tempo += float.Parse(row["Tempo"].ToString()) >= 60 ? float.Parse(row["Tempo"].ToString()) / 60 : float.Parse(row["Tempo"].ToString()) / 100;
                }
            }
            txt_estimado.Text = tempo.ToString();
            txt_orcamento.Text = orcamento.ToString();
            Atualizar_Valores(Ordem(id_ordem, tempo, orcamento));
        }
        private int Get_ID(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                return int.Parse(dgv_servicos.Rows[e.RowIndex].Cells["ID_Servico"].Value.ToString());
            else
                return 0;
        }
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Prencher_Dados(int id_ordem)
        {
            DataTable dt_table = Consultar_Banco(Consulta_Ordem(id_ordem));
            if (Validar_DataTable(dt_table))
            {
                txt_veiculo.Text = Retornar_String(dt_table, "Veiculo");
                txt_responsavel.Text = Retornar_String(dt_table, "Nome");
                txt_cor.Text = Retornar_String(dt_table, "Cor_Predominante");
                txt_ano_fab.Text = Retornar_String(dt_table, "Ano_Fabricacao");
                txt_placa.Text = Retornar_String(dt_table, "Placa");
                txt_marca.Text = Retornar_String(dt_table, "Marca");
                txt_combustivel.Text = Retornar_String(dt_table, "Combustivel");
                txt_orcamento.Text = Retornar_String(dt_table, "Orcamento");
                txt_estimado.Text = Retornar_String(dt_table, "Tempo_Estimado");
                txt_data_abertura.Text = Retornar_String(dt_table, "Data_Abertura");
                txt_nota.Text = Retornar_String(dt_table, "Nota");
            }
        }
        private void Popular_DataGrid(DTB_Consulta dtb_consulta)
        {
            dgv_servicos.DataSource = Consultar_Banco(dtb_consulta);
            dgv_servicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Nomear_DataGrid(dgv_servicos);
        }
        private void Nomear_DataGrid(DataGridView dgv_dataGrid)
        {
            dgv_dataGrid.Columns[0].HeaderText = "ID";
            dgv_dataGrid.Columns[1].HeaderText = "Status";
            dgv_dataGrid.Columns[2].HeaderText = "Serviço";
            dgv_dataGrid.Columns[3].HeaderText = "Preço";
            dgv_dataGrid.Columns[4].HeaderText = "Estimado (Min)";
            dgv_dataGrid.Columns[5].HeaderText = "Observações";
        }
        // DATAGRID
        private void dgv_servicos_CellClick(object sender, DataGridViewCellEventArgs e) => this.id_servico = Get_ID(e);
        // BUTTONS
        private void btn_recalcular_Click(object sender, EventArgs e) => Recalcular_Dados(this.id_ordem);
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // BUTTON [STATUS]
        private void btn_cancel_Click(object sender, EventArgs e) => Alterar_Status(Servico(this.id_servico, this.id_ordem, DTC__Status_Servico.Cancelado));
        private void btn_pecas_Click(object sender, EventArgs e) => Alterar_Status(Servico(this.id_servico, this.id_ordem, DTC__Status_Servico.AGD_Pecas));
        private void btn_aguardar_Click(object sender, EventArgs e) => Alterar_Status(Servico(this.id_servico, this.id_ordem, DTC__Status_Servico.Aguardando));
        private void btn_concluir_Click(object sender, EventArgs e) => Alterar_Status(Servico(this.id_servico, this.id_ordem, DTC__Status_Servico.Concluido));
        private void btn_andamento_Click(object sender, EventArgs e) => Alterar_Status(Servico(this.id_servico, this.id_ordem, DTC__Status_Servico.Andamento));

        private void btn_emitir_Click(object sender, EventArgs e)
        {
            DataTable dt_table = new DataTable();
            dt_table = new Consultas().Consultar(Consulta_Ordem(this.id_ordem));
            new Frm_Relatorio("nota_ordem_servico.rdlc", dt_table).ShowDialog();
        }
    }
}
