using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace TST
{
    public class TST_Registro_Servico : DTO_Registro_Servico
    {
        public static bool Validar_Modelo(DTO_Registro_Servico dto_registro)
        {
            if (!(dto_registro is null))
                return Fpr_Validar_Modelo(dto_registro);
            else
                throw new ArgumentNullException(nameof(dto_registro));
        }
        private static bool Fpr_Validar_Modelo(DTO_Registro_Servico dto_registro)
        {
           if (string.IsNullOrWhiteSpace(dto_registro.str_Descricao))
                return false;
            else if (dto_registro.dec_Preco < 0)
                return false;
            else if (dto_registro.dte_Data == null)
                return false;
            else
                return true;
        }
    }
}
