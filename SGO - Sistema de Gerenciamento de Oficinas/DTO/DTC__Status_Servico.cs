using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTC__Status_Servico
    {
        public static string Concluido => "CONCLUÍDO";
        public static string Andamento => "EM ANDAMENTO";
        public static string AGD_Pecas => "AGD. PEÇAS";
        public static string Aguardando => "AGUARDANDO";
        public static string Cancelado => "CANCELADO";
    }
}
