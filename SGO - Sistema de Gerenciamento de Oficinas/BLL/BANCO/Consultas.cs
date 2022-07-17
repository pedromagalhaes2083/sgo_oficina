using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace BLL
{
    public class Consultas : Interacoes_Banco
    {
    
        public DataTable Consultar(DTB_Consulta dtb_consulta)
        {
            try
            {
                if (!(dtb_consulta.str_Sql_Command is null))
                    return Consulta_Direta(dtb_consulta);
                else if (!(dtb_consulta.str_Tabela_Secundaria is null))
                    return Consultar_Join(dtb_consulta);
                else
                    return Retornar_Consulta(dtb_consulta);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(USER_MESSAGE.Erro_Consultar + ex.Message);
                return null;
            }
        }
        private DataTable Consultar_Join(DTB_Consulta dtb_consulta)
        {
            try
            {
                string str_Command = string.Empty;
                if(dtb_consulta.str_Condicao is null)
                    str_Command = $"SELECT {dtb_consulta.str_Parametros}  FROM {dtb_consulta.str_Tabela} LEFT JOIN {dtb_consulta.str_Tabela_Secundaria} ON {dtb_consulta.str_On_Join}";
                else
                    str_Command = $"SELECT {dtb_consulta.str_Parametros}  FROM {dtb_consulta.str_Tabela} LEFT JOIN {dtb_consulta.str_Tabela_Secundaria} ON {dtb_consulta.str_On_Join} WHERE {dtb_consulta.str_Condicao}";

                return Fpt_Retornar_DataTable(str_Command);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(USER_MESSAGE.Erro_Consultar + ex.Message);
                return null;
            }
        }
        private static DataTable Retornar_Consulta(DTB_Consulta dtb_consulta)
        {
            if (!(dtb_consulta is null))
            {
                string str_Command = string.Empty;
                if (dtb_consulta.str_Condicao is null)
                    str_Command = $"Select {dtb_consulta.str_Parametros} from {dtb_consulta.str_Tabela} order by {dtb_consulta.str_Parametro_Ordenador} DESC";
                else
                   str_Command = $"Select {dtb_consulta.str_Parametros} from {dtb_consulta.str_Tabela} where {dtb_consulta.str_Condicao.Replace(",", ".")} order by {dtb_consulta.str_Parametro_Ordenador} DESC";

                return Fpt_Retornar_DataTable(str_Command);
            }
            else
                throw new ArgumentNullException(nameof(dtb_consulta));
        }
        private static DataTable Consulta_Direta(DTB_Consulta dtb_consulta)
        {
            if (!(dtb_consulta is null) || string.IsNullOrWhiteSpace(dtb_consulta.str_Sql_Command))
            {
                return Fpt_Retornar_DataTable(dtb_consulta.str_Sql_Command);
            }
            else
                throw new ArgumentNullException(nameof(dtb_consulta.str_Sql_Command));
        }
    }
}
