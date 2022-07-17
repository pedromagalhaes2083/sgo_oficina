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
using TST;
using BLL;
using DTO;

namespace SGO___Sistema_de_Gerenciamento_de_Oficinas
{
    public partial class OPC_Ordem_Cancel : MetroForm
    {
        public OPC_Ordem_Cancel(int id)
        {
            InitializeComponent();
            this.id_ordem = id;
        }
        int id_ordem = 0;
        // MODELO [DTO]
        private DTO_Usuario Usuario()
        {
            DTO_Usuario dto_usuario = new DTO_Usuario();
            dto_usuario.str_Login = txt_login.Text;
            dto_usuario.str_Senha = txt_senha.Text;

            return dto_usuario;
        }
        private DTO_Ordem_Servico Ordem(int id_ordem)
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = id_ordem,
                str_Status = DTC_Status_Ordem.Cancelada
            };
            return dto_ordem;
        }
        // VALIDACOES [TST]
        private bool Validar_Ordem(DTO_Ordem_Servico dto_ordem) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, "s");
        // OPERACOES [BLL]
        private void Cancelar_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Ordem(dto_ordem))
                new Ordem_Servico().Fpu_Status_Ordem(dto_ordem);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private bool Verificar_Identidade(DTO_Usuario dto_usuario) => new Login().Efetuar_Login(dto_usuario);
        // OPERACOES
        private void Efetuar_Login(DTO_Usuario dto_usuario)
        {
            if (Verificar_Identidade(dto_usuario))
            {
                this.txt_login.ReadOnly = true;
                this.txt_senha.ReadOnly = true;
                Cancelar_Ordem(Ordem(this.id_ordem));
                MessageBox.Show(USER_MESSAGE.Login_Efetuado);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Credenciais_Invalidas);
        }
        // BUTTONS
        private void btn_confirmar_Click(object sender, EventArgs e) => Efetuar_Login(Usuario());
        private void btn_close_Click(object sender, EventArgs e) => this.Close();
    }
}
