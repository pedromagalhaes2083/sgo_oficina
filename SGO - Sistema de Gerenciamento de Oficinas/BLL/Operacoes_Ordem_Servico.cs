using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using TST;
using System.Windows.Forms;

namespace BLL
{
    public class Operacoes_Ordem_Servico
    {
        // TST 
        private bool Validar_Ordem(DTO_Ordem_Servico dto_ordem, string opr) => TST_Ordem_Servico.Validar_Modelo(dto_ordem, opr);
        private bool Validar_Servico(DTO_Servico_Pendente dto_servico) => TST_Servico_Pendente.Validar_Modelo(dto_servico);
        // OPERACOES >> BLL
        private void Alterar_Orcamento(DTO_Ordem_Servico dto_ordem, string opr)
        {
            if (Validar_Ordem(dto_ordem, "o"))
                new Ordem_Servico().Fpu_Update_Orcamento(dto_ordem, opr);
            else
                MessageBox.Show(USER_MESSAGE.Modelo_Invalido);
        }
        private void Fpr_Cancelar_Servico(DTO_Servico_Pendente dto_servico, DTO_Ordem_Servico dto_ordem)
        {
            if(Validar_Servico(dto_servico))
            {
                new Servico_Pendente().Fpu_Update_Status(dto_servico);
                Alterar_Orcamento(dto_ordem, "sub");
                new Status_Ordem().Gerenciar_Status(dto_servico.int_ID_Ordem);
            }
            else
                MessageBox.Show(USER_MESSAGE.Ordem_NEncontrada);
        }
        private void Fpr_Adicionar_Servico(DTO_Servico_Pendente dto_servico, DTO_Ordem_Servico dto_ordem)
        {
            if (Validar_Servico(dto_servico))
            {
                new Servico_Pendente().Fpu_Insert(dto_servico);
                Alterar_Orcamento(dto_ordem, "som");
                new Status_Ordem().Gerenciar_Status(dto_servico.int_ID_Ordem);
            }
            else
                MessageBox.Show(USER_MESSAGE.Ordem_NEncontrada);
        }
        // CHAMADAS 
        public void Cancelar_Servico(DTO_Servico_Pendente dto_servico, DTO_Ordem_Servico dto_ordem)
        {
            if (!(dto_servico is null || dto_ordem is null))
                Fpr_Cancelar_Servico(dto_servico, dto_ordem);
            else
                throw new ArgumentNullException("param. off");
        }
        public void Adicionar_Servico(DTO_Servico_Pendente dto_servico, DTO_Ordem_Servico dto_ordem)
        {
            if (!(dto_servico is null || dto_ordem is null))
                Fpr_Adicionar_Servico(dto_servico, dto_ordem);
            else
                throw new ArgumentNullException("param. off");
        }
    }
}
