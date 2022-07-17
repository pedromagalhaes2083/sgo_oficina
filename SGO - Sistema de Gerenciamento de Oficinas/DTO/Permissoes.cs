using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Permissoes
    {
        public static bool Cliente => true; // OK
        public static bool Ordem_Servico => true;
        public static bool Servico => true; // OK
        public static bool Usuario => true; // OK
        public static bool Financas => true; 
        public static bool Veiculo => true; // OK
        public static bool Analise => true;

    }
}
