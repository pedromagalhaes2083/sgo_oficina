using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Listas_Status
    {
        public List<string> Lista_Status_Ordem()
        {
            List<string> lista = new List<string>();
            lista.Add(DTC_Status_Ordem.Aberta);
            lista.Add(DTC_Status_Ordem.Concluida);
            lista.Add(DTC_Status_Ordem.Quitada);
            lista.Add(DTC_Status_Ordem.Cancelada);

            return lista;
        }
    }
}
