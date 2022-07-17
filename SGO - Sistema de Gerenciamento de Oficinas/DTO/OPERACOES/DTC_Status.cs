using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTC_Status 
    {
        public static string Bloqueado => "BLOQUEADO";
        public static string Liberado => "LIBERADO";
        public List<string> Lista_Status()
        {
            List<string> lista = new List<string>();
            lista.Add(Bloqueado);
            lista.Add(Liberado);
           

            return lista;
        }
    }
}
