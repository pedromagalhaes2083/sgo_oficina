using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Servico_Pendente
    {
        /*
            Adicionado posteriormente a uma ordem de serviço, feito apenas após sua abertura, devem referenciar tanto o veiculo como o servico pelo ID
         */
        public int int_ID { get; set; }
        public int int_ID_Ordem { get; set; }
        public int int_ID_Servico { get; set; }
        public string str_Status { get; set; }    
        public string str_Observacoes { get; set; }
    }
}
