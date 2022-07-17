using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Veiculo : DTO_Veiculo
    {
        public static bool Validar_Modelo(DTO_Veiculo dto_veiculo)
        {
            if (!(dto_veiculo is null))
                return Fpr_Validar_Modelo(dto_veiculo);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }
        public static bool Validar_Nome_Alt(DTO_Veiculo dto_veiculo)
        {
            if (!(dto_veiculo is null))
                return Fpr_Validar_Nome_Alt(dto_veiculo);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }
        private static bool Fpr_Validar_Nome_Alt(DTO_Veiculo dto_veiculo)
        {
            if (dto_veiculo.int_ID_Responsavel <= 0)
                return false;
            else
                return true;
        }
        private static bool Fpr_Validar_Modelo(DTO_Veiculo dto_veiculo)
        {
            if (string.IsNullOrWhiteSpace(dto_veiculo.str_Veiculo))
                return false;
            else if (string.IsNullOrWhiteSpace(dto_veiculo.str_Tipo))
                return false;
            else if (string.IsNullOrWhiteSpace(dto_veiculo.str_Cor_Predominante))
                return false;
            else if (string.IsNullOrWhiteSpace(dto_veiculo.str_Marca))
                return false;
            else
                return true;
        }
    }
}
