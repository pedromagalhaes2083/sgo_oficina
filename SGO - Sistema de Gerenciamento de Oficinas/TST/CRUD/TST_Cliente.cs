using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Cliente : DTO_Cliente
    {
        public static bool Validar_Modelo(DTO_Cliente dto_cliente)
        {
            if (!(dto_cliente is null))
                return Fpr_Validar_Modelo(dto_cliente);
            else
                throw new ArgumentNullException(nameof(dto_cliente));
        }
        private static bool Fpr_Validar_Modelo(DTO_Cliente dto_cliente)
        {
            if (string.IsNullOrWhiteSpace(dto_cliente.str_Nome))
                return false;
            else if (string.IsNullOrWhiteSpace(dto_cliente.str_Endereco))
                return false;
            else if (string.IsNullOrWhiteSpace(dto_cliente.str_Status))
                return false;
            else
                return true;
        }
    }
}
