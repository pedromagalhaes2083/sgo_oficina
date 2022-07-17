using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using TST;
using System.Data.SqlClient;
using System.Data;


namespace BLL
{
    public class Servico : DTO_Servico
    {
        public void Fpu_Insert(DTO_Servico dto_servico)
        {
            string str_Command = $"INSERT INTO {DTB_Tabelas.Servico} (Nome, Preco, Tempo, Observacoes) VALUES (@nome, @preco, @tempo, @observacoes)";
            if (!(dto_servico is null))
                Fpr_SQL_Metodo(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Update(DTO_Servico dto_servico)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Servico} SET Nome = @nome, Preco = @preco, Tempo = @tempo, Observacoes = @observacoes WHERE ID = @id";
            if (!(dto_servico is null))
                Fpr_SQL_Metodo(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Delete(DTO_Servico dto_servico)
        {
            string str_Command = $"DELETE {DTB_Tabelas.Servico} WHERE ID = @id";
            if (!(dto_servico is null))
                Fpr_SQL_Identificador(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        private void Fpr_SQL_Metodo(DTO_Servico dto_servico, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_servico.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_servico.int_ID);
                    _ = sqlCommand.Parameters.AddWithValue("@nome", dto_servico.str_Servico);
                    _ = sqlCommand.Parameters.AddWithValue("@preco", dto_servico.dec_Valor);
                    _ = sqlCommand.Parameters.AddWithValue("@tempo", dto_servico.int_Tempo);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_servico.str_Observacoes);
                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Servico dto_servico, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id", dto_servico.int_ID);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Servico))
                        _ = sqlCommand.Parameters.AddWithValue("@nome", dto_servico.str_Servico);
                    if (dto_servico.dec_Valor > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@preco", dto_servico.dec_Valor);
                    if (dto_servico.int_Tempo > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@tempo", dto_servico.int_Tempo);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Observacoes))
                        _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_servico.str_Observacoes);
                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
