using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Quitar_Ordem : DTO_Ordem_Servico
    {
        public static bool Validar_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            if (!(dto_ordem is null))
                return Fpr_Validar_Modelo(dto_ordem);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        private static bool Fpr_Validar_Modelo(DTO_Ordem_Servico dto_ordem)
        {
            if (dto_ordem.dec_Orcamento <= 0)
                return false;
            else if (dto_ordem.dec_Total_Quitado < 0)
                return false;
            else if (dto_ordem.int_ID <= 0)
                return false;
            else
                return true;
        }
    }
}
