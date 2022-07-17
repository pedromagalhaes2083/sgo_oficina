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
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }
        // Load
        private void Main_Load(object sender, EventArgs e)
        {
            Recolher_Panels();
        }
        // Variaveis de Controle
        int permissao = 0;
        // Modelos >> DTO
        private DTO_Usuario Usuario()
        {
            DTO_Usuario dto_usuario = new DTO_Usuario();
            dto_usuario.str_Login = txt_login.Text;
            dto_usuario.str_Senha = txt_senha.Text;

            return dto_usuario;
        }
        // Validacoes >> TST
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        // Operacoes >> BLL
        private bool Login(DTO_Usuario dto_usuario) => new Login().Efetuar_Login(dto_usuario);
        private void Efetuar_Login(DTO_Usuario dto_usuario)
        {
            if (Login(dto_usuario))
            {
                MessageBox.Show(USER_MESSAGE.Login_Efetuado);
                this.txt_login.ReadOnly = true;
                this.txt_senha.ReadOnly = true;
                btn_efetuar_login.Text = "Logoff";
                btn_efetuar_login.BackColor = Color.Crimson;
                this.permissao = 1;

                Recolher_Panels();
            }
            else
                MessageBox.Show(USER_MESSAGE.Credenciais_Invalidas);
        }
        // Operacoes
        private void Efetuar_Logoff()
        {
            txt_login.Text = "";
            txt_senha.Text = "";
            this.txt_login.ReadOnly = false;
            this.txt_senha.ReadOnly = false;
            btn_efetuar_login.Text = "Login";
            btn_efetuar_login.BackColor = Color.FromArgb(0, 153, 255);
            this.permissao = 0;

            Recolher_Panels();
        }
        private void Atualiza_Menu(Panel panel)
        {
            foreach (var item in this.Controls)
            {
                if (item is Panel && item != panel && item != pnl_base_esquerda && item != pnl_base_superior && item != pnl_bar_action)
                    ((Panel)item).Visible = false;
                else if (item == panel)
                    ((Panel)item).Visible = !((Panel)item).Visible;
            }
        }
        private void Recolher_Panels()
        {
            foreach (var item in this.Controls)
            {
                if (item is Panel && item != pnl_base_esquerda && item != pnl_base_superior && item != pnl_base_superior && item != pnl_bar_action)
                    ((Panel)item).Visible = false;
            }
        }
        private void Fechar_Formularios_Filhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }
        // Button - Login
        private void btn_efetuar_login_Click(object sender, EventArgs e)
        {
            if (btn_efetuar_login.Text.Equals("Login"))
            {
                if (!string.IsNullOrWhiteSpace(txt_login.Text) && !string.IsNullOrWhiteSpace(txt_senha.Text))
                    Efetuar_Login(Usuario());
                else
                    MessageBox.Show(USER_MESSAGE.Credenciais_Invalidas);
            }
            else
                Efetuar_Logoff();
        }
        // Button - StateWindow / Close
        private void btn_state_window_Click(object sender, EventArgs e)
        {
            if (this.WindowState is FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

            Recolher_Panels();
        }
        private void btn_close_Click(object sender, EventArgs e) => this.Close();
        // ActionBar - Topo
        private void btn_bar_veiculos_Click(object sender, EventArgs e)
        {
            if (Permissoes.Veiculo)
                Atualiza_Menu(pnl_veiculos);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }

        private void btn_bar_servicos_Click(object sender, EventArgs e)
        {
            if (Permissoes.Servico)
                Atualiza_Menu(pnl_servicos);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }

        private void btn_bar_ordens_Click(object sender, EventArgs e)
        {
            if (Permissoes.Ordem_Servico)
                Atualiza_Menu(pnl_ordens);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }

        private void btn_bar_analise_Click(object sender, EventArgs e)
        {
            if (Permissoes.Analise)
                Atualiza_Menu(pnl_analise);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }

        private void btn_bar_financas_Click(object sender, EventArgs e)
        {
            if (Permissoes.Financas)
                Atualiza_Menu(pnl_financas);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }

        private void btn_bar_clientes_Click(object sender, EventArgs e)
        {
            if (Permissoes.Cliente)
                Atualiza_Menu(pnl_clientes);
            else
                MessageBox.Show(USER_MESSAGE.Funcionalidade_Indisponivel);
        }
        // Buttons - Bar - Lateral
        private void btn_lat_login_Click(object sender, EventArgs e) => Atualiza_Menu(pnl_login);
        private void btn_lat_novo_cliente_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Cad_Cliente frm_Cad_Cliente = new Frm_Cad_Cliente();
                frm_Cad_Cliente.MdiParent = this;
                frm_Cad_Cliente.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_lat_abrir_ordem_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Abrir_Ordem_Servico frm_Abrir_Ordem_Servico = new Frm_Abrir_Ordem_Servico();
                frm_Abrir_Ordem_Servico.MdiParent = this;
                frm_Abrir_Ordem_Servico.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_lat_novo_veiculo_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Cad_Veiculo frm_Cad_Veiculo = new Frm_Cad_Veiculo();
                frm_Cad_Veiculo.MdiParent = this;
                frm_Cad_Veiculo.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_lat_usuarios_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Usuario frm_Usuario = new Frm_Usuario();
                frm_Usuario.MdiParent = this;
                frm_Usuario.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        // Buttons - Chamdas
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Cliente frm_Cliente = new Frm_Cliente();
                frm_Cliente.MdiParent = this;
                frm_Cliente.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_fin_ordens_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Ordem_Financeiro frm_Ordem_Financeiro = new Frm_Ordem_Financeiro();
                frm_Ordem_Financeiro.MdiParent = this;
                frm_Ordem_Financeiro.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_producao_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Ordem_Analise frm_Ordem_Analise = new Frm_Ordem_Analise();
                frm_Ordem_Analise.MdiParent = this;
                frm_Ordem_Analise.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }

        private void btn_ordens_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Ordem frm_Ordem = new Frm_Ordem();
                frm_Ordem.MdiParent = this;
                frm_Ordem.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }

        }
        private void btn_servicos_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Servico frm_Servico = new Frm_Servico();
                frm_Servico.MdiParent = this;
                frm_Servico.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
        private void btn_veiculos_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Veiculo frm_Veiculo = new Frm_Veiculo();
                frm_Veiculo.MdiParent = this;
                frm_Veiculo.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {

        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.permissao))
            {
                Frm_Registro_Servico frm_Registro_Servico = new Frm_Registro_Servico();
                frm_Registro_Servico.MdiParent = this;
                frm_Registro_Servico.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            if(Validar_Identificador(this.permissao))
            {
                Frm_Backup frm_Backup = new Frm_Backup();
                frm_Backup.MdiParent = this;
                frm_Backup.Show();

                Recolher_Panels();
            }
            else
            {
                MessageBox.Show(USER_MESSAGE.Efetue_Login);
                Recolher_Panels();
            }
        }
    }
}
