using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TST
{
    public class TST_DataTable
    {
        public static bool Valida_Modelo(DataTable dt_table)
        {
            if (dt_table != null)
                return Fpr_Validar_Modelo(dt_table);
            else
                throw new ArgumentNullException(nameof(dt_table));
        }
        private static bool Fpr_Validar_Modelo(DataTable dt_table) => dt_table.Rows.Count <= 0 ? false : true;
    }
}
