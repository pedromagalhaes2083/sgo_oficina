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
    public partial class OPC_Cliente : MetroForm
    {
        public OPC_Cliente(int id)
        {
            InitializeComponent();
            this.id_cliente = id;
        }
        int id_cliente = 0;
        // MODELO
        private DTO_Cliente Cliente(int id_cliente)
        {
            DTO_Cliente dto_cliente = new DTO_Cliente
            {
                int_ID = id_cliente,
                str_Status = DTC_Status.Bloqueado
            };
            return dto_cliente;
        }
        private DTB_Consulta Consultar_Cliente(int id_cliente)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Parametros = "Status_Cliente",
                str_Parametro_Ordenador = "ID",
                str_Tabela = DTB_Tabelas.Cliente,
                str_Condicao = $"ID = {id_cliente}"
            };

            return dtb_consulta;
        }
        // VALIDACOES
        private bool Validar_Identificador(int i) => TST_Identificador.Validar_Identificador(i);
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => TST_Consulta.Validar_Modelo(dtb_consulta);
        // OPERACOES [BLL]
        private DataTable Consultar(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Bloquear_Cliente(DTO_Cliente dto_cliente)
        {
            if (Validar_Identificador(dto_cliente.int_ID) && DialogResult.OK == MessageBox.Show(USER_MESSAGE.Messagem_Bloqueio))
                new Cliente().Fpu_Alterar_Status(dto_cliente);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void Deletar_Cliente(DTO_Cliente dto_cliente)
        {
            if (Validar_Identificador(dto_cliente.int_ID) && DialogResult.OK == MessageBox.Show(USER_MESSAGE.Messagem_Exclusao))
                new Cliente().Fpu_Delete(dto_cliente);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        // OPERACOES 
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows.Count > 0 ? dt_table.Rows[0][parametro].ToString() : null;
        private void Verificar_Status(int id_cliente)
        {
            string status = Retornar_String(Consultar(Consultar_Cliente(id_cliente)), "Status_Cliente");
            btn_bloquear.Text = status.Equals(DTC_Status.Liberado) ? "Bloquear" : "Excluir";
        }
        private void Seletor(DTO_Cliente dto_cliente)
        {
            if (btn_bloquear.Text.Equals("Bloquear"))
                Bloquear_Cliente(dto_cliente);
            else
                Deletar_Cliente(dto_cliente);
            this.Close();
        }
        // BUTTON
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Validar_Identificador(this.id_cliente))
            {
                _ = new Frm_Alter_Cliente(this.id_cliente).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void btn_bloquear_Click(object sender, EventArgs e) => Seletor(Cliente(this.id_cliente));
        // LOAD
        private void OPC_Cliente_Load(object sender, EventArgs e) => Verificar_Status(this.id_cliente);
    }
}
