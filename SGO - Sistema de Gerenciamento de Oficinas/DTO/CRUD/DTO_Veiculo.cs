using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Veiculo
    {
        public int int_ID { get; set; }
        public int int_ID_Responsavel { get; set; }
        public string str_Veiculo { get; set; }
        public string str_Combustivel { get; set; }
        public string str_Tipo { get; set; }
        public string str_Placa { get; set; }
        public string str_Cor_Predominante { get; set; }
        public string str_Chassi { get; set; }
        public int int_Ano_Fabricacao { get; set; }
        public string str_Observacoes_Gerais { get; set; }
        public string str_Marca { get; set; }
    }
}
