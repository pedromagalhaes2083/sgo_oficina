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
using BLL;
using DTO;
using TST;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class Frm_Cad_Servico : MetroForm
    {
        public Frm_Cad_Servico()
        {
            InitializeComponent();
        }
        // Modelo
        private DTO_Servico_Avulso Servico()
        {
            DTO_Servico_Avulso dto_servico = new DTO_Servico_Avulso
            {
                str_Servico = txt_nome.Text,
                int_Tempo = int.Parse(txt_tempo.Text),
                dec_Valor = Convert.ToDecimal(txt_preco.Text),
                str_Observacoes = txt_observacoes.Text
            };

            return dto_servico;
        }
        private DTB_Consulta Consulta_Servico(string pesquisa)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Tabela = DTB_Tabelas.Servico,
                str_Parametros = "ID",
                str_Parametro_Ordenador = "ID",
                str_Condicao = $"Nome LIKE '{pesquisa}'"
            };
            return dtb_consulta;
        }
        // Validacoes >> TST
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        private bool Validar_Servico(DTO_Servico_Avulso dto_servico) => TST_Servico.Validar_Modelo(dto_servico);
        // Operacoes >> BLL
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Cadastrar(DTO_Servico_Avulso dto_servico) => new Servico().Fpu_Insert(dto_servico);
        // Operacoes
        private bool Verificar_Existencia(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            return dt_table.Rows.Count > 0;
        }
        private void Limpar()
        {
            txt_nome.Text = string.Empty;
            txt_observacoes.Text = string.Empty;
            txt_preco.Text = string.Empty;
            txt_tempo.Text = string.Empty;
        }
        private void Cadastrar_Servico(DTO_Servico_Avulso dto_servico)
        {
            if (Validar_Servico(dto_servico))
            {
                if (!Verificar_Existencia(Consulta_Servico(txt_nome.Text)))
                {
                    Cadastrar(dto_servico);
                    Limpar();
                    MessageBox.Show(USER_MESSAGE.Sucesso);
                }
                else
                    MessageBox.Show(USER_MESSAGE.Servico_Existente);
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Buttons
        private void btn_cadastrar_Click(object sender, EventArgs e) => Cadastrar_Servico(Servico());
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
    }
}
