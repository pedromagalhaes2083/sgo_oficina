using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Servico_Avulso
    {
        public int int_ID { get; set; }
        public string str_Status { get; set; }
        public string str_Descricao { get; set; }
        public decimal dec_Valor { get; set; }
        public DateTime dte_data { get; set; }
        public string str_Observacoes { get; set; }
    }
}
