using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class DTO_Ordem_Servico
    {
		/*
			A ordem é aberta e posteriormente são acrescentados os serviços a serem feitos
		 */
		public int int_ID { get; set; }
		public int int_ID_Veiculo { get; set; }
		public int int_ID_Responsavel { get; set; }
		public string str_Combustivel { get; set; }
		public string str_Observacoes_Cliente { get; set; }
		public string str_Observacoes_Avaria { get; set; }
		public float flt_Tempo_Estimado { get; set; }
		public decimal dec_Orcamento { get; set; }
		public decimal dec_Total_Quitado { get; set; }
		public string str_Status { get; set; }
		public DateTime dte_Abertura { get; set; }
		public DateTime dte_Termino { get; set; }
		public string str_Nota { get; set; }
    }
}
