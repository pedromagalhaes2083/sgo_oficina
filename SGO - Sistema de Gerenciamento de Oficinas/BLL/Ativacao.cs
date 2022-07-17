using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace BLL
{
    public class Ativacao : DTO_Ativacao
    {
        public void Fpu_Ativar(DTO_Ativacao dto_ativacao)
        {
            string str_Command = $"INSERT INTO {DTB_Tabelas.Ativacao} (Chave) VALUES (@chave)";
            if (!(dto_ativacao is null))
            {
                Fpr_Ativar(dto_ativacao, str_Command);
                Fpr_Root_User();
            }
            else
                throw new ArgumentNullException(nameof(dto_ativacao));
        }
        private void Fpr_Root_User()
        {
            using (SqlConnection sqlConnection = new DTO.Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();
                    string str_Command = "insert into tb_Usuarios (Nome, Login, Senha) Values ('SIMÃO PEDRO SOUSA MAGALHÃES','ROOT', 'pesogo2083')";
                    _ = sqlCommand.CommandText = str_Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_Ativar(DTO_Ativacao dto_ativacao, string str_Command)
        {
            using (SqlConnection sqlConnection = new DTO.Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@chave", dto_ativacao.str_Chave);

                    _ = sqlCommand.CommandText = str_Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
