using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Recibo
    {
        private int int_ID { get; set; }
        public int int_ID_Cliente { get; set; }
        public string str_Descricao { get; set; }
        public string str_Observacoes { get; set; }
        public decimal dec_Valor { get; set; }
        public int int_Tipo { get; set; }
        public int int_Ordem { get; set; }
        public int int_Servico { get; set;} // Refere-se a serviços avulsos
        public DateTime dte_Data { get; set; }
    }
}
