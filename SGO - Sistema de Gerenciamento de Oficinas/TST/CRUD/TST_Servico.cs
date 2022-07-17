using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Servico : DTO_Servico_Avulso
    {
        public static bool Validar_Modelo(DTO_Servico_Avulso dto_servico)
        {
            if (!(dto_servico is null))
                return Fpr_Validar_Modelo(dto_servico);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        private static bool Fpr_Validar_Modelo(DTO_Servico_Avulso dto_servico)
        {
            if (string.IsNullOrWhiteSpace(dto_servico.str_Servico))
                return false;
            else if (dto_servico.int_Tempo <= 0)
                return false;
            else if (dto_servico.dec_Valor <= 0)
                return false;
            else
                return true;
        }
    }
}
