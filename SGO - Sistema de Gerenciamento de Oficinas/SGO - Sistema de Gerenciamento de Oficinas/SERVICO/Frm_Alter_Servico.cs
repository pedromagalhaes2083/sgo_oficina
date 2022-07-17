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
    public partial class Frm_Alter_Servico : MetroForm
    {
        public Frm_Alter_Servico(int id)
        {
            InitializeComponent();
            this.id_servico = id;
        }
        int id_servico;
        // Modelo
        private DTB_Consulta Consulta_Servico(int id)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Servico;
            dtb_consulta.str_Parametros = "ID, Nome, Observacoes, Tempo, Preco";
            dtb_consulta.str_Parametro_Ordenador = "ID";
            dtb_consulta.str_Condicao = $"ID = {id}";

            return dtb_consulta;
        }
        private DTO_Servico_Avulso Servico()
        {
            DTO_Servico_Avulso dto_servico = new DTO_Servico_Avulso();
            dto_servico.int_ID = this.id_servico;
            dto_servico.str_Servico = txt_nome.Text;
            dto_servico.int_Tempo = int.Parse(txt_tempo.Text);
            dto_servico.dec_Valor = Convert.ToDecimal(txt_preco.Text);
            dto_servico.str_Observacoes = txt_observacoes.Text;

            return dto_servico;
        }
        // Validacoes
        private bool Validar_Servico(DTO_Servico_Avulso dto_servico) => TST_Servico.Validar_Modelo(dto_servico);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private DataTable Consultar(DTB_Consulta dtb_consulta)
        {
            if (Validar_Consulta(dtb_consulta))
                return new Consultas().Consultar(dtb_consulta);
            else
                return null;
        }
        private void Alterar(DTO_Servico_Avulso dto_servico) => new Servico().Fpu_Update(dto_servico);
        private void Alterar_Servico(DTO_Servico_Avulso dto_servico)
        {
            if (Validar_Servico(dto_servico))
            {
                Alterar(dto_servico);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Operacoes
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Prencher(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                txt_nome.Text = Retornar_String(dt_table, "Nome");
                txt_observacoes.Text = Retornar_String(dt_table, "Observacoes");
                txt_preco.Text = Retornar_String(dt_table, "Preco");
                txt_tempo.Text = Retornar_String(dt_table, "Tempo");
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Consultar);
        }
        // Buttons
        private void btn_editar_Click(object sender, EventArgs e) => Alterar_Servico(Servico());
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // Load
        private void Frm_Alter_Servico_Load(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.id_servico))
                Prencher(Consulta_Servico(this.id_servico));
        }
    }
}
