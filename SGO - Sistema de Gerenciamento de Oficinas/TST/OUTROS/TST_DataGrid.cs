using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TST
{
    public static class TST_DataGrid
    {
        public static bool Validar_Modelo(DataGridView dgv_dataGrid)
        {
            if (!(dgv_dataGrid is null))
                return Fpr_Validar_Modelo(dgv_dataGrid);
            else
                throw new ArgumentNullException(nameof(dgv_dataGrid));
        }
        private static bool Fpr_Validar_Modelo(DataGridView dgv_datagrid)
        {
            if (dgv_datagrid.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
