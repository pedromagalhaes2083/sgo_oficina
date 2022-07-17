using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Ordem_Servico : DTO_Ordem_Servico
    {
        public static bool Validar_Modelo(DTO_Ordem_Servico dto_ordem, string key)
        {
            if (!(dto_ordem is null))
            {
                if (key.Equals("a"))
                    return Fpr_Validar_Modelo(dto_ordem);
                else if (key.Equals("s"))
                    return Fpr_Validar_Status(dto_ordem);
                else if (key.Equals("o"))
                    return Fpr_Validar_Orcamento(dto_ordem);
                else if (key.Equals("q"))
                    return Fpr_Validar_Quitar(dto_ordem);
                else if (key.Equals("n"))
                    return Fpr_Validar_Nota(dto_ordem);
                else if (key.Equals("u"))
                    return Fpr_Validar_Alteracao(dto_ordem);
                else
                    return false;
            }
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public static bool Validar_Status(DTO_Ordem_Servico dto_ordem)
        {
            if (!(dto_ordem is null))
                return Fpr_Validar_Status(dto_ordem);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        private static bool Fpr_Validar_Status(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID <= 0)
                return false;
            else if (string.IsNullOrWhiteSpace(dto_ordem.str_Status))
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Modelo(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID_Veiculo <= 0)
                return false;
            else if (dto_ordem.int_ID_Responsavel <= 0)
                return false;
            else if (dto_ordem.flt_Tempo_Estimado < 0)
                return false;
            else if (dto_ordem.dec_Orcamento < 0)
                return false;
            else if (string.IsNullOrWhiteSpace(dto_ordem.str_Status))
                return false;
            else if (dto_ordem.dte_Abertura == null)
                return false;
            else if (string.IsNullOrWhiteSpace(dto_ordem.str_Combustivel))
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Alteracao(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID <= 0)
                return false;
            else if (dto_ordem.dec_Orcamento < 0)
                return false;
            else if (dto_ordem.flt_Tempo_Estimado < 0)
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Orcamento(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID <= 0)
                return false;
            else if (dto_ordem.dec_Orcamento < 0)
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Quitar(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID <= 0)
                return false;
            else if (dto_ordem.dec_Total_Quitado < 0)
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Nota(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.int_ID <= 0)
                return false;
            else if (string.IsNullOrWhiteSpace(dto_ordem.str_Nota))
                return false;
            else
                return true;
        }
    }
}
