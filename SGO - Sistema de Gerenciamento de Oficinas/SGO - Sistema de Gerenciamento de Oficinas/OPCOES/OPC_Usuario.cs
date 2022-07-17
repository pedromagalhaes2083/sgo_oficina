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
    public partial class OPC_Usuario : MetroForm
    {
        public OPC_Usuario(int id_usuario)
        {
            InitializeComponent();
            if (Validar_Identificador(id_usuario))
                this.id = id_usuario;
            else
                this.Close();
        }
        int id = 0;
        // Validacoes >> TST
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private void Delete_Usuario(int id_usuario)
        {
            new OPR_Exclusao_Usuario(id_usuario).ShowDialog();
            this.Dispose();
        }
        // Buttons
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
        private void btn_editar_Click(object sender, EventArgs e)
        {
            new Frm_Alter_Usuario(this.id).ShowDialog();
            this.Dispose();
        }
        private void btn_excluir_Click(object sender, EventArgs e) => Delete_Usuario(this.id);
    }
}
