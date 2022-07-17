using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Ordem_Servico : DTO_Ordem_Servico
    {
        public void Fpu_Insert(DTO_Ordem_Servico dto_ordem)
        {
            string str_Command = $"INSERT INTO {DTB_Tabelas.Ordem_Servico} (ID_Veiculo, Combustivel, Observacoes_Cliente, Observacoes_Avaria, Tempo_Estimado, Orcamento, Status_Ordem, ID_Responsavel,  Quitado, Data_Abertura, Nota) VALUES (@id_veiculo, @combustivel, @observacoes_cliente, @observacoes_avaria, @tempo_estimado, @orcamento, @status,  @id_responsavel,  @quitado, @data_abertura, @nota)";
            if (!(dto_ordem is null))
                Fpr_SQL_Metodo(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Update_TOrcamento(DTO_Ordem_Servico dto_ordem)
        {
            string str_command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Orcamento = @orcamento, Tempo_Estimado = @tempo_estimado WHERE ID = @id";
            if (!(dto_ordem is null))
                Fpr_SQL_Identificador(dto_ordem, str_command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Update_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Orcamento = @orcamento, Tempo_Estimado = @tempo_estimado, Observacoes_Avaria = @observacoes_avaria, Observacoes_Cliente = @observacoes_cliente, Nota = @nota WHERE ID = {dto_ordem.int_ID}";
            if (!(dto_ordem is null))
                Fpr_SQL_Metodo(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Update_Orcamento(DTO_Ordem_Servico dto_ordem, string opr)
        {
            string str_Command = string.Empty;
            if (opr.Equals("som"))
                 str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Orcamento += @orcamento, Tempo_Estimado += @tempo_estimado WHERE ID = @id";
            else if(opr.Equals("sub"))
                str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Orcamento = @orcamento, Tempo_Estimado = @tempo_estimado WHERE ID = @id";

            if (!(dto_ordem is null))
                Fpr_SQL_Identificador(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Update_Quitagem(DTO_Ordem_Servico dto_ordem)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Quitado += @quitado WHERE ID = @id";
            if (!(dto_ordem is null))
                Fpr_SQL_Identificador(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Update_Nota(DTO_Ordem_Servico dto_ordem)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Nota = @nota WHERE ID = @id";
            if (!(dto_ordem is null))
                Fpr_SQL_Identificador(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        public void Fpu_Status_Ordem(DTO_Ordem_Servico dto_ordem)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Ordem_Servico} SET Status_Ordem = @status WHERE ID = @id";
            if (!(dto_ordem is null))
                Fpr_SQL_Identificador(dto_ordem, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_ordem));
        }
        private void Fpr_SQL_Metodo(DTO_Ordem_Servico dto_ordem, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id_veiculo", dto_ordem.int_ID_Veiculo);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes_cliente", dto_ordem.str_Observacoes_Cliente);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes_avaria", dto_ordem.str_Observacoes_Avaria);
                    _ = sqlCommand.Parameters.AddWithValue("@tempo_estimado", dto_ordem.flt_Tempo_Estimado);
                    _ = sqlCommand.Parameters.AddWithValue("@orcamento", dto_ordem.dec_Orcamento);
                    _ = sqlCommand.Parameters.AddWithValue("@quitado", dto_ordem.dec_Total_Quitado);
                    _ = sqlCommand.Parameters.AddWithValue("@combustivel", dto_ordem.str_Combustivel);
                    _ = sqlCommand.Parameters.AddWithValue("@status", dto_ordem.str_Status);
                    _ = sqlCommand.Parameters.AddWithValue("@id_responsavel", dto_ordem.int_ID_Responsavel);
                    _ = sqlCommand.Parameters.AddWithValue("@data_abertura", dto_ordem.dte_Abertura);
                    _ = sqlCommand.Parameters.AddWithValue("@nota", dto_ordem.str_Nota);


                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Ordem_Servico dto_ordem, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_ordem.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_ordem.int_ID);
                    if (dto_ordem.dec_Orcamento >= 0)
                        _ = sqlCommand.Parameters.AddWithValue("@orcamento", dto_ordem.dec_Orcamento);
                    if (!string.IsNullOrWhiteSpace(dto_ordem.str_Nota))
                        _ = sqlCommand.Parameters.AddWithValue("@nota", dto_ordem.str_Nota);
                    if (dec_Total_Quitado >= 0)
                        _ = sqlCommand.Parameters.AddWithValue("@quitado", dto_ordem.dec_Total_Quitado);
                    if (dto_ordem.flt_Tempo_Estimado >= 0)
                        _ = sqlCommand.Parameters.AddWithValue("@tempo_estimado", dto_ordem.flt_Tempo_Estimado);
                    if (!string.IsNullOrWhiteSpace(dto_ordem.str_Status))
                        _ = sqlCommand.Parameters.AddWithValue("@status", dto_ordem.str_Status);

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
