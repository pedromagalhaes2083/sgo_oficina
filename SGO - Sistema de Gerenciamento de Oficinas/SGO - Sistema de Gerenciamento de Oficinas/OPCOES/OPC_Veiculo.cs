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
    public partial class OPC_Veiculo : MetroForm
    {
        public OPC_Veiculo(int id)
        {
            InitializeComponent();
            this.id_veiculo = id;
        }
        int id_veiculo = 0;
        // Modelo
        private DTO_Veiculo Veiculo(int id_veiculo)
        {
            DTO_Veiculo dto_veiculo = new DTO_Veiculo();
            dto_veiculo.int_ID = id_veiculo;

            return dto_veiculo;
        }
        // Validacoes
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private void Deletar_Veiculo(DTO_Veiculo dto_veiculo)
        {
            if (Validar_Identificador(dto_veiculo.int_ID))
                new Veiculo().Fpu_Delete(dto_veiculo);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Operacoes 
        private void Deletar(DTO_Veiculo dto_veiculo)
        {
            if (DialogResult.OK == MessageBox.Show(USER_MESSAGE.Messagem_Exclusao))
                Deletar_Veiculo(dto_veiculo);
            this.Close();
        }
        // Buttons
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.id_veiculo))
            {
                new Frm_Alter_Veiculo(this.id_veiculo).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void btn_excluir_Click(object sender, EventArgs e) => Deletar(Veiculo(this.id_veiculo));
    }
}
