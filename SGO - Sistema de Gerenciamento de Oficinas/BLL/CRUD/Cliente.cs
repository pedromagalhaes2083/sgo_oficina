using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace BLL
{
    public class Cliente : DTO_Cliente
    {
        public void Fpu_Insert(DTO_Cliente dto_cliente)
        {
            string Command = $"INSERT INTO {DTB_Tabelas.Cliente} (Nome, Endereco, Telefone, Apelido, Status_Cliente, Observacoes) VALUES (@nome, @endereco, @telefone, @apelido, @status,  @observacoes)";
            if (!(dto_cliente is null))
                Fpr_SQL_Metodo(dto_cliente, Command);
            else
                throw new ArgumentNullException(nameof(dto_cliente));
        }
        public void Fpu_Update(DTO_Cliente dto_cliente)
        {
            string Command = $"UPDATE {DTB_Tabelas.Cliente} SET Nome = @nome, Endereco = @endereco, Telefone = @telefone, Apelido = @apelido, Status_Cliente = @status, Observacoes = @observacoes WHERE ID = @id";
            if (!(dto_cliente is null))
                Fpr_SQL_Metodo(dto_cliente, Command);
            else
                throw new ArgumentNullException(nameof(dto_cliente));
        }
        public void Fpu_Delete(DTO_Cliente dto_cliente)
        {
            string Command = $"DELETE {DTB_Tabelas.Cliente} WHERE ID = @id";
            if (!(dto_cliente is null))
                Fpr_SQL_Identificador(dto_cliente, Command);
            else
                throw new ArgumentNullException(nameof(dto_cliente));
        }
        public void Fpu_Alterar_Status(DTO_Cliente dto_cliente)
        {
            string Command = $"UPDATE {DTB_Tabelas.Cliente} SET Status_Cliente = @status WHERE ID = @id";
            if (!(dto_cliente is null))
                Fpr_SQL_Identificador(dto_cliente, Command);
            else
                throw new ArgumentNullException(nameof
                    (dto_cliente));
        }
        private void Fpr_SQL_Metodo(DTO_Cliente dto_cliente, string str_Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_cliente.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_cliente.int_ID);
                    _ = sqlCommand.Parameters.AddWithValue("@nome", dto_cliente.str_Nome);
                    _ = sqlCommand.Parameters.AddWithValue("@endereco", dto_cliente.str_Endereco);
                    _ = sqlCommand.Parameters.AddWithValue("@telefone", dto_cliente.str_Telefone);
                    _ = sqlCommand.Parameters.AddWithValue("@apelido", dto_cliente.str_Apelido);
                    _ = sqlCommand.Parameters.AddWithValue("@status", dto_cliente.str_Status);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_cliente.str_Observacoes);

                    _ = sqlCommand.CommandText = str_Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Cliente dto_cliente, string str_Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_cliente.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_cliente.int_ID);
                    if (!string.IsNullOrWhiteSpace(dto_cliente.str_Nome))
                        _ = sqlCommand.Parameters.AddWithValue("@nome", dto_cliente.str_Nome);
                    if (!string.IsNullOrWhiteSpace(dto_cliente.str_Endereco))
                        _ = sqlCommand.Parameters.AddWithValue("@endereco", dto_cliente.str_Endereco);
                    if (!string.IsNullOrWhiteSpace(dto_cliente.str_Telefone))
                        _ = sqlCommand.Parameters.AddWithValue("@telefone", dto_cliente.str_Telefone);
                    if (!string.IsNullOrWhiteSpace(dto_cliente.str_Apelido))
                        _ = sqlCommand.Parameters.AddWithValue("@apelido", dto_cliente.str_Apelido);
                    if (!string.IsNullOrWhiteSpace(dto_cliente.str_Status))
                        _ = sqlCommand.Parameters.AddWithValue("@status", dto_cliente.str_Status);

                    _ = sqlCommand.CommandText = str_Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }

        }
    }
}
