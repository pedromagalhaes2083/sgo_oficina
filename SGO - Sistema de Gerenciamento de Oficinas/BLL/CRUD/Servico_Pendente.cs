using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace BLL
{
    public class Servico_Pendente : DTO_Servico_Pendente
    {
        public void Fpu_Insert(DTO_Servico_Pendente dto_servico)
        {
            string str_Command = $"INSERT INTO {DTB_Tabelas.Servico_Pendente} (ID_Servico, Status_Servico, ID_Ordem, Observacoes) VALUES (@id_servico, @status_servico, @id_ordem, @observacoes)";
            if (!(dto_servico is null))
                Fpr_SQL_Metodo(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Update_Status(DTO_Servico_Pendente dto_servico)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Servico_Pendente} SET Status_Servico = @status_servico WHERE ID_Servico = @id_servico AND ID_Ordem = @id_ordem";
            if (!(dto_servico is null))
                Fpr_SQL_Identificador(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Update_All_Status(DTO_Servico_Pendente dto_servico)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Servico} SET Status_Servico = @status_servico WHERE ID_Ordem = @id_ordem ";
            if (!(dto_servico is null))
                Fpr_SQL_Identificador(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Delete(DTO_Servico_Pendente dto_servico)
        {
            string str_Command = $"DELETE {DTB_Tabelas.Servico} WHERE ID = @id";
            if (!(dto_servico is null))
                Fpr_SQL_Identificador(dto_servico, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        private void Fpr_SQL_Metodo(DTO_Servico_Pendente dto_servico, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_servico.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_servico.int_ID);
                    _ = sqlCommand.Parameters.AddWithValue("@id_servico", dto_servico.int_ID_Servico);
                    _ = sqlCommand.Parameters.AddWithValue("@id_ordem", dto_servico.int_ID_Ordem);
                    _ = sqlCommand.Parameters.AddWithValue("@status_servico", dto_servico.str_Status);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_servico.str_Observacoes);

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Servico_Pendente dto_servico, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_servico.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_servico.int_ID);
                    if (dto_servico.int_ID_Ordem > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id_ordem", dto_servico.int_ID_Ordem);
                    if (dto_servico.int_ID_Servico > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id_servico", dto_servico.int_ID_Servico);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Status))
                        _ = sqlCommand.Parameters.AddWithValue("@status_servico", dto_servico.str_Status);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Observacoes))
                        _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_servico.str_Observacoes);
                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
