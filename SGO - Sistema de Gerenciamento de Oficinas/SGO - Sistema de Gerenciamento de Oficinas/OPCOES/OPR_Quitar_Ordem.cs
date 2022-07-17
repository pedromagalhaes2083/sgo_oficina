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
    public partial class OPR_Quitar_Ordem : MetroForm
    {
        public OPR_Quitar_Ordem(int id)
        {
            InitializeComponent();
            if (Validar_Identificador(id))
                this.id_ordem = id;
            else
                this.Dispose();
        }
        int id_ordem = 0;
        DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico();
        // Modelos >> DTO
        private DTB_Consulta Consulta_Ordem(int id_ordem)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Ordem_Servico;
            dtb_consulta.str_Parametros = "Orcamento_Final, Total_Quitado";
            dtb_consulta.str_Parametro_Ordenador = "ID";
            dtb_consulta.str_Condicao = $"ID = {id_ordem}";

            return dtb_consulta;
        }
        private DTO_Ordem_Servico Ordem_Servico(decimal dec_total, decimal dec_quitado, decimal dec_quitar)
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico();
            dto_ordem.dec_Total_Quitado = dec_quitado + dec_quitar;

            return dto_ordem;
        }
        // Validacoes >> TST
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_Quitagem(DTO_Ordem_Servico dto_ordem) => TST_Quitar_Ordem.Validar_Ordem(dto_ordem);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        // Operacoes >> BLL
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta)
        {
            if (Validar_Consulta(dtb_consulta))
                return new Consultas().Consultar(dtb_consulta);
            else
                return null;
        }
        private void Quitar_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Quitagem(dto_ordem))
            {
                new Ordem_Servico().Fpu_Update_Quitagem(dto_ordem);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Operacoes
        private decimal Retornar_Decimal(DataTable dt_table, string parametro) => decimal.Parse(dt_table.Rows[0][parametro].ToString());
        private void Prencher_Ordem(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                this.dto_ordem.dec_Orcamento = Retornar_Decimal(dt_table, "Orcamento");
                this.dto_ordem.dec_Total_Quitado = Retornar_Decimal(dt_table, "Total_Quitado");
            }
            else
                this.Close();
        }
        // Load
        private void OPR_Quitar_Ordem_Load(object sender, EventArgs e) => Prencher_Ordem(Consulta_Ordem(this.id_ordem));
        // Buttons
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Quitar_Ordem(Ordem_Servico(Convert.ToDecimal(txt_total), Convert.ToDecimal(txt_total_quitado), Convert.ToDecimal(txt_valor_quitar)));
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
