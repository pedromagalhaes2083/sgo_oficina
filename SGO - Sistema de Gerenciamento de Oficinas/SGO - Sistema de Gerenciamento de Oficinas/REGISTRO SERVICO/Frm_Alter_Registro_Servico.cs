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
    public partial class Frm_Alter_Registro_Servico : MetroForm
    {
        public Frm_Alter_Registro_Servico(int id)
        {
            InitializeComponent();
            this.id_registro = id;
        }
        int id_registro = 0;
        // LOAD
        private void Frm_Alter_Registro_Servico_Load(object sender, EventArgs e)
        {
            Prenher_Campos(Consultar_Banco(Consulta_Registro(this.id_registro)));
        }
        // MODELO >> DTB
        private DTB_Consulta Consulta_Registro(int id_registro)
        {
            string cliente = DTB_Tabelas.Cliente;
            string registro = DTB_Tabelas.Registro_Servico;

            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Sql_Command = $"SELECT {registro}.ID, {registro}.Data, {cliente}.Nome, {registro}.Descricao, {registro}.Preco, {registro}.Observacoes FROM {registro} INNER JOIN {cliente} ON {registro}.ID_Cliente = {cliente}.ID WHERE {registro}.ID = {id_registro} "
            };

            return dtb_consulta;
        }
        private DTO_Registro_Servico Registro_Servico()
        {
            DTO_Registro_Servico dto_registro = new DTO_Registro_Servico()
            {
                str_Descricao = txt_descricao.Text,
                str_Observacao = txt_observacoes.Text,
                dte_Data = dtp_data.Value,
                dec_Preco = decimal.Parse(mkt_valor.Text),
                int_ID = this.id_registro
            };

            return dto_registro;
        }
        // VALIDACOES 
        private bool Validar_Consulta(DTB_Consulta dtb_consulta) => !string.IsNullOrWhiteSpace(dtb_consulta.str_Sql_Command);
        private bool Validar_DataTable(DataTable dt_table) => TST_DataTable.Valida_Modelo(dt_table);
        private bool Validar_Registro(DTO_Registro_Servico dto_registro) => TST_Registro_Servico.Validar_Modelo(dto_registro);
        // OPERACOES >> BLL
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => Validar_Consulta(dtb_consulta) ? new Consultas().Consultar(dtb_consulta) : null;
        private void Editar_Registro(DTO_Registro_Servico dto_registro) => new Registro_Servico().Fpu_Update(dto_registro);
        // OPERACOES 
        private void Editar(DTO_Registro_Servico dto_registro)
        {
            if (Validar_Registro(dto_registro))
            {
                Editar_Registro(Registro_Servico());
                this.Close();
            }
        }
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        private void Prenher_Campos(DataTable dt_table)
        {
            if (Validar_DataTable(dt_table))
            {
                txt_descricao.Text = Retornar_String(dt_table, "Descricao");
                txt_observacoes.Text = Retornar_String(dt_table, "Observacoes");
                mkt_valor.Text = Retornar_String(dt_table, "Preco");
                dtp_data.Value = DateTime.Parse(Retornar_String(dt_table, "Data"));
            }
        }
        // BUTTUNS
        private void btn_voltar_Click(object sender, EventArgs e) => this.Close();
        private void btn_editar_Click(object sender, EventArgs e) => Editar(Registro_Servico());
    }
}
