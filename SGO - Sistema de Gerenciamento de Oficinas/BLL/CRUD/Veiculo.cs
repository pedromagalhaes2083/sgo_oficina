using DTO;
using TST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace BLL
{
    public class Veiculo : DTO_Veiculo
    {
        public void Fpu_Insert(DTO_Veiculo dto_veiculo)
        {
            string Command = $"INSERT INTO {DTB_Tabelas.Veiculo} (Veiculo, Tipo, Placa, Cor_Predominante, Chassi, Ano_Fabricacao, Observacoes_gerais, Marca,  ID_Responsavel, Combustivel) VALUES (@veiculo, @tipo, @placa, @cor_predominante, @chassi, @ano_fabricacao, @observacoes_gerais, @marca, @id_responsavel, @combustivel)";
            if (!(dto_veiculo is null))
                Fpr_SQL_Metodo(dto_veiculo, Command);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }
        public void Fpu_Update(DTO_Veiculo dto_veiculo)
        {
            string Command = $"UPDATE {DTB_Tabelas.Veiculo} SET Veiculo = @veiculo, Tipo = @tipo, Placa = @placa, Cor_Predominante = @cor_predominante, Chassi = @chassi, Ano_Fabricacao = @ano_fabricacao, Observacoes_Gerais = @observacoes_gerais, Marca = @marca, Combustivel = @combustivel WHERE ID = @id";
            if (!(dto_veiculo is null))
                Fpr_SQL_Metodo(dto_veiculo, Command);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }
        public void Fpu_Alterar_Responsavel(DTO_Veiculo dto_veiculo)
        {
            string Command = $"UPDATE {DTB_Tabelas.Veiculo} SET ID_Responsavel = @id_responsavel WHERE ID = @id";
            if (!(dto_veiculo is null))
                Fpr_SQL_Identificador(dto_veiculo, Command);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }
        public void Fpu_Delete(DTO_Veiculo dto_veiculo)
        {
            string Command = $"DELETE FROM {DTB_Tabelas.Veiculo} WHERE ID = @id";
            if (!(dto_veiculo is null))
                Fpr_SQL_Identificador(dto_veiculo, Command);
            else
                throw new ArgumentNullException(nameof(dto_veiculo));
        }      
        private void Fpr_SQL_Metodo(DTO_Veiculo dto_veiculo, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    if (dto_veiculo.int_ID > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id", dto_veiculo.int_ID);                  
                    if(dto_veiculo.int_ID_Responsavel > 0)
                        _ = sqlCommand.Parameters.AddWithValue("@id_responsavel", dto_veiculo.int_ID_Responsavel);
                    _ = sqlCommand.Parameters.AddWithValue("@veiculo", dto_veiculo.str_Veiculo);
                    _ = sqlCommand.Parameters.AddWithValue("@tipo", dto_veiculo.str_Tipo);
                    _ = sqlCommand.Parameters.AddWithValue("@placa", dto_veiculo.str_Placa);
                    _ = sqlCommand.Parameters.AddWithValue("@cor_predominante", dto_veiculo.str_Cor_Predominante);
                    _ = sqlCommand.Parameters.AddWithValue("@chassi", dto_veiculo.str_Chassi);
                    _ = sqlCommand.Parameters.AddWithValue("@ano_fabricacao", dto_veiculo.int_Ano_Fabricacao);
                    _ = sqlCommand.Parameters.AddWithValue("@observacoes_gerais", dto_veiculo.str_Observacoes_Gerais);
                    _ = sqlCommand.Parameters.AddWithValue("@marca", dto_veiculo.str_Marca);
                    _ = sqlCommand.Parameters.AddWithValue("@combustivel", dto_veiculo.str_Combustivel);

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private void Fpr_SQL_Identificador(DTO_Veiculo dto_veiculo, string Command)
        {
            using (SqlConnection sqlConnection = new Conexao_SQL().Conectar)
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlConnection Connection = sqlCommand.Connection = sqlConnection;
                    Connection.Open();

                    _ = sqlCommand.Parameters.AddWithValue("@id", dto_veiculo.int_ID);                  

                    sqlCommand.CommandText = Command;
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
