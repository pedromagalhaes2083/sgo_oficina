using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public  class Backup
    {
        public static void Backup_Banco(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho))
                caminho = "";
            DTB_Consulta dtb_backup = new DTB_Consulta()
            {
                str_Sql_Command = $@"BACKUP DATABASE [{Conexao_SQL.Banco}] TO DISK = N'{caminho}\oficina_{DateTime.Now.ToString().Replace("/", "").Replace("-", "").Replace(":", "").Replace(" ", "_")}.bak' WITH NOFORMAT, NOINIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10;"
            };

            new Consultas().Consultar(dtb_backup);
        }
    }
}
