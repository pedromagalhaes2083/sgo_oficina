using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace BLL
{
    public class Registro_Servico : DTO_Registro_Servico
    {
        public void Fpu_Insert(DTO_Registro_Servico dto_registro)
        {
            string str_Command = $"INSERT INTO {DTB_Tabelas.Registro_Servico} (ID_Cliente, Descricao, Preco, Observacoes, Data)  VALUES (@id_cliente, @descricao, @preco, @observacoes, @data)";
            if (!(dto_registro is null))
                Fpr_SQL_Metodo(dto_registro, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_registro));
        }
        public void Fpu_Update(DTO_Registro_Servico dto_registro)
        {
            string str_Command = $"UPDATE {DTB_Tabelas.Registro_Servico} SET Descricao = @descricao, Preco = @preco, Observacoes = @observacoes  WHERE ID = @id";
            if (!(dto_registro is null))
                Fpr_SQL_Identificador(dto_registro, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_registro));
        }
        public void Fpu_Delete(DTO_Registro_Servico dto_registro)
        {
            string str_Command = $"DELETE {DTB_Tabelas.Registro_Servico} WHERE ID = @id";
            if (!(dto_registro is null))
                Fpr_SQL_Identificador(dto_registro, str_Command);
            else
                throw new ArgumentNullException(nameof(dto_registro));
        }
        private void Fpr_SQL_Metodo(DTO_Registro_Servico dto_registro, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id_cliente", dto_registro.int_ID_Cliente);
                    _ = sqlCommand.Parameters.AddWithValue("@descricao", dto_registro.str_Descricao);
                    _ = sqlCommand.Parameters.AddWithValue("@preco", dto_registro.dec_Preco);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_registro.str_Observacao);
                    _ = sqlCommand.Parameters.AddWithValue("@data", dto_registro.dte_Data);

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Registro_Servico dto_registro, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id", dto_registro.int_ID);
                    if (!string.IsNullOrWhiteSpace(dto_registro.str_Descricao))
                        _ = sqlCommand.Parameters.AddWithValue("@descricao", dto_registro.str_Descricao);
                    if (dto_registro.dec_Preco >= 0)
                        _ = sqlCommand.Parameters.AddWithValue("@preco", dto_registro.dec_Preco);
                    if (!string.IsNullOrWhiteSpace(dto_registro.str_Observacao))
                        _ = sqlCommand.Parameters.AddWithValue("@observacoes", dto_registro.str_Observacao);
                    if (dto_registro.dte_Data == null)
                        _ = sqlCommand.Parameters.AddWithValue("@data", dto_registro.dte_Data);

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
