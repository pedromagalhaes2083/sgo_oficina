using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTC_Status_Ordem
    {
        public static string Aberta => "ABERTA";
        public static string Concluida => "CONCLUÍDA";
        public static string Quitada => "QUITADA";
        public static string Cancelada => "CANCELADA";
    }
}
