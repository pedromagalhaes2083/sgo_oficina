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
    public partial class Frm_Ordem_Quitar : MetroForm
    {
        public Frm_Ordem_Quitar(int id)
        {
            InitializeComponent();
            this.id_ordem = id;
        }
        int id_ordem = 0;
        // LOAD
        private void Frm_Ordem_Quitar_Load(object sender, EventArgs e) => Consultar_Valor(this.id_ordem);
        // MODELO [DTB]
        private DTB_Consulta Consulta_Ordem(int id_ordem)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = DTB_Tabelas.Ordem_Servico,
                str_Parametros = "ID, Orcamento, Quitado, Status_Ordem",
                str_Parametro_Ordenador = "ID",
                str_Condicao = $"ID = {id_ordem}"

            };

            return dtb_consulta;
        }
        private DTO_Ordem_Servico Ordem(string quitado)
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = this.id_ordem,
                dec_Total_Quitado = decimal.Parse(quitado)
            };

            return dto_ordem;
        }
        // VALIDACOES [TST]
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_Quitacao(DTO_Ordem_Servico dto_ordem) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, "q");
        // OPERACOES [BLL]
        private DataTable Consulta_Banco(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Atualizar_Orcamento(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Quitacao(dto_ordem))
            {
                new Ordem_Servico().Fpu_Update_Quitagem(dto_ordem);
                new Status_Ordem().Gerenciar_Status(dto_ordem.int_ID);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // OPERACOES 
        private string  Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Consultar_Valor(int id_ordem)
        {
            DataTable dt_table = Consulta_Banco(Consulta_Ordem(id_ordem));
            if (!Validar_DataTable(dt_table) || Retornar_String(dt_table, "Status_Ordem").Equals(DTC_Status_Ordem.Quitada) || Retornar_String(dt_table, "Status_Ordem").Equals(DTC_Status_Ordem.Cancelada))
                this.Close();
            else
            {
                txt_orcamento.Text = Retornar_String(dt_table, "Orcamento");
                txt_quitado.Text = Retornar_String(dt_table, "Quitado");
            }
        }
        // BUTTON
        private void btn_confirmar_Click(object sender, EventArgs e) => Atualizar_Orcamento(Ordem(txt_quitar.Text));
        private void btn_close_Click(object sender, EventArgs e) => this.Close();
    }
}
