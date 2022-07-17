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
    public partial class Frm_Alter_Cliente : MetroForm
    {
        public Frm_Alter_Cliente(int id_cliente)
        {
            InitializeComponent();
            this.id = id_cliente;
        }
        int id = 0;
        // MODELOS [DTO]
        private DTB_Consulta Consulta_Cliente(int id_cliente)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta();
            dtb_consulta.str_Tabela = DTB_Tabelas.Cliente;
            dtb_consulta.str_Parametros = "Nome, Endereco, Apelido, Status_Cliente, Telefone, Observacoes";
            dtb_consulta.str_Parametro_Ordenador = "ID";
            dtb_consulta.str_Condicao = $"ID = {id_cliente}";

            return dtb_consulta;
        }
        private DTO_Cliente Cliente(int id_cliente)
        {
            DTO_Cliente dto_cliente = new DTO_Cliente();
            dto_cliente.int_ID = id_cliente;
            dto_cliente.str_Nome = txt_nome.Text.ToUpper();
            dto_cliente.str_Apelido = txt_apelido.Text.ToUpper();
            dto_cliente.str_Endereco = txt_endereco.Text.ToUpper();
            dto_cliente.str_Observacoes = txt_observacoes.Text.ToUpper();
            dto_cliente.str_Telefone = mkt_telefone.Text;
            dto_cliente.str_Status = cbx_status.Text;

            return dto_cliente;
        }       
        // VALIDACOES [DTO]
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Cliente(DTO_Cliente dto_cliente) => TST_Cliente.Validar_Modelo(dto_cliente);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Alterar_Cliente(DTO_Cliente dto_cliente) => new Cliente().Fpu_Update(dto_cliente);
     
        private void Prencher_Campos(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar(dtb_consulta);
            if (Validar_DataTable(dt_table))
            {
                txt_nome.Text = Retornar_String(dt_table, "Nome");
                txt_endereco.Text = Retornar_String(dt_table, "Endereco");
                txt_apelido.Text = Retornar_String(dt_table, "Apelido");
                txt_observacoes.Text = Retornar_String(dt_table, "Observacoes");
                cbx_status.SelectedIndex = cbx_status.FindString(Retornar_String(dt_table, "Status_Cliente"));
                mkt_telefone.Text = Retornar_String(dt_table, "Telefone");
            }
            else
                MessageBox.Show(USER_MESSAGE.Erro_Consultar);
        }
        // OPERACOES
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Alterar(DTO_Cliente dto_cliente)
        {
            if (Validar_Cliente(dto_cliente) && Validar_Identificador(dto_cliente.int_ID))
            {
                Alterar_Cliente(dto_cliente);
                MessageBox.Show(USER_MESSAGE.Sucesso);
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // BUTTON
        private void btn_editar_Click(object sender, EventArgs e) => Alterar(Cliente(this.id));
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        // LOAD
        private void Frm_Alter_Cliente_Load(object sender, EventArgs e)
        {
            cbx_status.DataSource = new DTC_Status().Lista_Status();
            Prencher_Campos(Consulta_Cliente(this.id));
        }
    }
}
