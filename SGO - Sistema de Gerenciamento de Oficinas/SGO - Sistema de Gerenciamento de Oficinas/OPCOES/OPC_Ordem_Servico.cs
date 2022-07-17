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
    public partial class OPC_Ordem_Servico : MetroForm
    {
        public OPC_Ordem_Servico(int id)
        {
            InitializeComponent();
            this.id_ordem = id;
        }
        int id_ordem = 0;
        // MODELO [DTO]
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
        // BUTTONS
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Validar_Ordem(Ordem(this.id_ordem)))
            {
                new OPC_Ordem_Cancel(this.id_ordem).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void btn_sair_Click(object sender, EventArgs e) => this.Close();
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Validar_Ordem(Ordem(this.id_ordem)))
            {
                new Frm_Alter_Ordem(this.id_ordem).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);

        }
        private void btn_servicos_Click(object sender, EventArgs e)
        {
            if (Validar_Ordem(Ordem(this.id_ordem)))
            {
                new Frm_Ordem_Servico(Ordem(this.id_ordem)).ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
    }
}
