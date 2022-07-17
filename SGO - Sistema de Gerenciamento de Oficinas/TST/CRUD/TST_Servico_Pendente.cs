using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Servico_Pendente : DTO_Servico_Pendente
    {
        public static bool Validar_Modelo(DTO_Servico_Pendente dto_servico)
        {
            if (!(dto_servico is null))
                return Fpr_Validar_Pendente(dto_servico);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        private static bool Fpr_Validar_Pendente(DTO_Servico_Pendente dto_servico)
        {
            if (dto_servico.int_ID_Ordem <= 0)
                return false;
            else if (dto_servico.int_ID_Servico <= 0)
                return false;
            else if (string.IsNullOrWhiteSpace(dto_servico.str_Status))
                return false;
            else
                return true;
        }
    }
}
