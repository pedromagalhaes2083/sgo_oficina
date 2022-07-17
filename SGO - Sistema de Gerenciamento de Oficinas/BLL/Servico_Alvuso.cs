using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using TST;

namespace BLL
{
    public class Servico_Alvuso : DTO_Servico_Avulso
    {
        public void Fpu_Insert(DTO_Servico_Avulso dto_servico)
        {
            if (!(dto_servico is null))
            {
                string str_command = $"INSERT INTO {DTB_Tabelas.Servico_Avulso} (Descricao, Observacoes, Valor, Data, Status_Servico) VALUES (@descricao, @observacoes, @valor, GetDate(), @status)";
                Fpr_Executar_Command(str_command, dto_servico);
            }
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        public void Fpu_Update(DTO_Servico_Avulso dto_servico)
        {
            if (!(dto_servico is null))
            {
                string str_command = $"UPDATE {DTB_Tabelas.Servico_Avulso} SET Descricao = @descricao, Observacoes = @observacoes, Valor = @valor, Status_Servico = @status WHERE ID = @id";
                Fpr_Executar_Command(str_command, dto_servico);
            }
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }public void Fpu_Delete(DTO_Servico_Avulso dto_servico)
        {
            if (!(dto_servico is null))
            {
                string str_command = $"DELETE {DTB_Tabelas.Servico_Avulso} WHERE ID = @id";
                Fpr_Executar_Command(str_command, dto_servico);
            }
            else
                throw new ArgumentNullException(nameof(dto_servico));
        }
        private void Fpr_Executar_Command(string str_command, DTO_Servico_Avulso dto_servico)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id", dto_servico.int_ID);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Descricao))
                        _ = sqlCommand.Parameters.AddWithValue("@descricao", dto_servico.str_Descricao);
                    if (dto_servico.dec_Valor > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@preco", dto_servico.dec_Valor);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Observacoes))
                        _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_servico.str_Observacoes);
                    if (!string.IsNullOrWhiteSpace(dto_servico.str_Status))
                        _ = sqlCommand.Parameters.AddWithValue("@status", dto_servico.str_Status);
                    sqlCommand.CommandText = str_command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
