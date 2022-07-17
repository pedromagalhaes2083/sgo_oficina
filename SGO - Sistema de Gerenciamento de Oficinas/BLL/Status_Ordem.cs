using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using TST;
using System.Data;

namespace BLL
{
    public class Status_Ordem : DTO_Ordem_Servico
    {
        // MODELO [DTO]
        private DTO_Ordem_Servico Ordem_Servico(int id_ordem, string dtc_status)
        {
            DTO_Ordem_Servico dto_ordem = new DTO_Ordem_Servico()
            {
                int_ID = id_ordem,
                str_Status = dtc_status
            };
            return dto_ordem;
        }
        private DTB_Consulta Consulta_Ordem(int id_ordem)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Parametros = "ID, Status_Ordem",
                str_Parametro_Ordenador = "ID",
                str_Condicao = $"ID = {id_ordem}",
                str_Tabela = DTB_Tabelas.Ordem_Servico
            };
            return dtb_consulta;
        }
        private DTB_Consulta Consultar_Quitado(int id_ordem)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Parametros = "ID, Status_Ordem, Quitado",
                str_Parametro_Ordenador = "ID",
                str_Condicao = $"Orcamento = Quitado",
                str_Tabela = DTB_Tabelas.Ordem_Servico
            };

            return dtb_consulta;
        }
        private DTB_Consulta Consulta_Pendente(int id_ordem)
        {
            DTB_Consulta dtb_consulta = new DTB_Consulta()
            {
                str_Parametros = "ID_Ordem, Status_Servico",
                str_Parametro_Ordenador = "ID_Ordem",
                str_Condicao = $"ID_Ordem = {id_ordem} AND Status_Servico NOT LIKE '{DTC__Status_Servico.Concluido}' AND Status_Servico NOT LIKE '{DTC__Status_Servico.Cancelado}' ",
                str_Tabela = DTB_Tabelas.Servico_Pendente
            };
            return dtb_consulta;
        }
        // VALIDACOES 
        private int Validar_Existecia(DTB_Consulta dtb_consulta)
        {
            DataTable dt_table = Consultar_Banco(dtb_consulta);
            return dt_table.Rows.Count > 0 ? dt_table.Rows.Count : 0;
        }
        // OPERACOES [BLL]
        private DataTable Consultar_Banco(DTB_Consulta dtb_consulta) => new Consultas().Consultar(dtb_consulta);
        private void Alterar_Status_Ordem(DTO_Ordem_Servico dto_ordem) => new Ordem_Servico().Fpu_Status_Ordem(dto_ordem);
        // OPERACOES
        private string CStatus_Ordem(int id_ordem) => Retornar_String(Consultar_Banco(Consulta_Ordem(id_ordem)), "Status_Ordem");
        private void Gerenciar_Acoes(int id_ordem)
        {
            string status = CStatus_Ordem(id_ordem);
            if (status.Equals(DTC_Status_Ordem.Aberta))
                Verificar_Servicos(id_ordem);
            else if (status.Equals(DTC_Status_Ordem.Concluida) || status.Equals(DTC_Status_Ordem.Quitada))
                Abrir_Ordem(id_ordem);
        }
        private string Retornar_String(DataTable dt_table, string parametro) => dt_table.Rows[0][parametro].ToString();
        // ORDENS - STATUS
        private void Abrir_Ordem(int id_ordem)
        {
            /* .: se houver um ou mais servicos pendentes a ordem deve mudar o status para aberta
            essa checagem deve ser feita toda vez que se adicione um novo servico. */

            if (Validar_Existecia(Consulta_Pendente(id_ordem)) > 0)
                Alterar_Status_Ordem(Ordem_Servico(id_ordem, DTC_Status_Ordem.Aberta));
        }
        private void Verificar_Servicos(int id_ordem)
        {
            /*.: Se não houver nenhum servico com status diferente de CONCLUIDO a ordem
	        deve mudar seu status para CONCLUIDA/QUITADA. */

            if (Validar_Existecia(Consulta_Pendente(id_ordem)) == 0)
                Modificar_Status(id_ordem);
        }
        private void Modificar_Status(int id_ordem)
        {
            /* Ao finalizar a ordem a mesma deve verificar o valor quitado e caso esse valor seja igual ao orçamento 
	        a mesma seja ticada como QUITADA antes mesmo de ser feita qualquer outra verificação */

            if (Validar_Existecia(Consultar_Quitado(id_ordem)) > 0)
                Alterar_Status_Ordem(Ordem_Servico(id_ordem, DTC_Status_Ordem.Quitada));
            else
                Alterar_Status_Ordem(Ordem_Servico(id_ordem, DTC_Status_Ordem.Concluida));
        }
        // CHAMADAS
        public void Gerenciar_Status(int id_ordem)
        {
            if (id_ordem > 0)
                Gerenciar_Acoes(id_ordem);
            else
                throw new ArgumentNullException(nameof(id_ordem));
        }
    }
}
