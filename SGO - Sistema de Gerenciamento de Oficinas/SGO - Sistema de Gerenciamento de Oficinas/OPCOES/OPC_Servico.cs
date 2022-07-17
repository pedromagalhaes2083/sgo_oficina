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
    public partial class OPC_Servico : MetroForm
    {
        public OPC_Servico(int id)
        {
            InitializeComponent();
            if (Validar_Identificador(id))
                this.id_servico = id;
        }
        int id_servico;
        // Modelo
        private DTO_Servico_Avulso Servico()
        {
            DTO_Servico_Avulso dto_servico = new DTO_Servico_Avulso();
            dto_servico.int_ID = this.id_servico;

            return dto_servico;
        }
        // Validacoes
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private void Deletar_Servico(DTO_Servico_Avulso dto_servico)
        {
            if (Validar_Identificador(dto_servico.int_ID))
                new Servico().Fpu_Delete(dto_servico);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Operacoes
        private void Deletar(DTO_Servico_Avulso dto_servico)
        {
            if (DialogResult.OK == MessageBox.Show(USER_MESSAGE.Messagem_Exclusao))
                Deletar_Servico(dto_servico);
            this.Close();
        }
        // Buttons
        private void btn_editar_Click(object sender, EventArgs e)
        {
            _ = new Frm_Alter_Servico(this.id_servico).ShowDialog();
            this.Close();
        }
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
        private void btn_excluir_Click(object sender, EventArgs e) => Deletar(Servico());

    }
}
