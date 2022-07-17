using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTO
{
    public class Conexao_SQL
    {
        public SqlConnection Conectar
        {
            get
            {
                
                return new SqlConnection($@"Data Source={Environment.MachineName}\SQLEXPRESS;Initial Catalog=  {Banco} ; Integrated Security = True; Pooling= False;  MultipleActiveResultSets = true ");
            }
        }
        public static string Banco
        {
            get
            {
                return "SGO-Oficina";
            }
        }
    }
}
