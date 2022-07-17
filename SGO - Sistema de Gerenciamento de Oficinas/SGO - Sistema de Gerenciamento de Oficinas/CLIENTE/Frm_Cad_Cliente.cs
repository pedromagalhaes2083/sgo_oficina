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
    public partial class Frm_Cad_Cliente : MetroForm
    {
        public Frm_Cad_Cliente()
        {
            InitializeComponent();
        }
        // Modelos
        private DTO_Cliente Cliente()
        {
            DTO_Cliente dto_cliente = new DTO_Cliente();
            dto_cliente.str_Nome = txt_nome.Text;
            dto_cliente.str_Endereco = txt_endereco.Text;
            dto_cliente.str_Telefone = mkt_telefone.Text;
            dto_cliente.str_Status = DTC_Status.Liberado;
            dto_cliente.str_Observacoes = txt_observacoes.Text;
            dto_cliente.str_Status = DTC_Status.Liberado;
            dto_cliente.str_Apelido = txt_apelido.Text;

            return dto_cliente;
        }
        // Validacoes
        private bool Validar_Cliente(DTO_Cliente dto_cliente) => TST_Cliente.Validar_Modelo(dto_cliente);
        // Operacoes >> BLL
        private void Cadastrar_Cliente(DTO_Cliente dto_cliente) => new Cliente().Fpu_Insert(dto_cliente);
        // Operacoes
        private void Cadastrar(DTO_Cliente dto_cliente)
        {
            if (Validar_Cliente(dto_cliente))
            {
                Cadastrar_Cliente(dto_cliente);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // Buttons
        private void btn_cadastrar_Click(object sender, EventArgs e) => Cadastrar(Cliente());
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
    }
}
