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
using BLL;
using TST;
using MetroFramework.Forms;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class OPC_Registro_Servico : MetroForm
    {
        public OPC_Registro_Servico(int id)
        {
            InitializeComponent();
            this.id_servico = id;
        }
        int id_servico = 0;
        // MODELO >> DTO
        private DTO_Registro_Servico Registro_Servico(int id_servico)
        {
            DTO_Registro_Servico dto_registro = new DTO_Registro_Servico()
            {
                int_ID = id_servico
            };

            return dto_registro;
        }
        // VALIDACOES >> TST
        private bool Validar_Identificador(int i) => i <= 0 ? false : true;
        // OPERACOES >> BLL
        private void Excluir(DTO_Registro_Servico dto_registro)
        {
            if (Validar_Identificador(dto_registro.int_ID))
            {
                new Registro_Servico().Fpu_Delete(dto_registro);
                MessageBox.Show(USER_MESSAGE.Sucesso);
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // OPERACOES
        private void Excluir_Registro(DTO_Registro_Servico dto_registro)
        {
            if (MessageBox.Show( "Deseja mesmo excluir esse registro.", "Exclusão do Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               Excluir(dto_registro);
            }
        }
        // EXCLUIR
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Excluir_Registro(Registro_Servico(this.id_servico));
            this.Close();
        }
        // EDITAR
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(this.id_servico > 0)
            {
                new Frm_Alter_Registro_Servico(this.id_servico).ShowDialog();
                this.Close();
            }
        }
        // SAIR
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
    }
}
