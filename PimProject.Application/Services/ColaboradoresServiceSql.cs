using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.DBContext;
using PimProject.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Services
{
    
    public class ColaboradoresServiceSql : ISqlColaboradoresServices
    {
        
        private readonly string _connectionString;
           

        public ColaboradoresServiceSql(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ColaboradoresServiceSql()
        {
        }

        public async Task<bool> AdicionarColaborador(ColaboradoresResponse response)
        {
            string sqlCommand = "INSERT INTO Colaborador (Nome_Completo, Data_Nascimento, CPF, Email) VALUES (@Nome_Completo, @Data_Nascimento, @CPF, @Email)";

           

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Nome_Completo", response.Nome_Completo },
                { "@Data_Nascimento", response.Data_Nascimento },
                { "@CPF", response.CPF },
                { "@Email", response.Email }

            };
            return await AdicionarAsync(sqlCommand, parameters);
        }

        public async Task<List<ColaboradoresResponse>> ExibirColaboradores()
        {
            var colaboradorViewList = new List<ColaboradoresResponse>();

            string connectionString = "Data Source=localhost;Database=PIM_III;Trusted_Connection=True;Trust Server Certificate = true;";

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT CPF, Nome_Completo, DATA_NASCIMENTO, EMAIL FROM Colaborador";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var colabViewModel = new ColaboradoresResponse();

                            colabViewModel.CPF = reader["CPF"].ToString();
                            colabViewModel.Nome_Completo = reader["Nome_Completo"].ToString();
                            colabViewModel.Data_Nascimento = reader["DATA_NASCIMENTO"].ToString();
                            colabViewModel.Email = reader["EMAIL"].ToString();

                            colaboradorViewList.Add(colabViewModel);
                        }
                    }
                }
            }

            return colaboradorViewList;
        }


        public async Task<bool> AdicionarAsync(string sqlCommand, Dictionary<string, object> parameters)
        {
            var cnn = "Data Source=localhost;Database=PIM_III;Trusted_Connection=True;Trust Server Certificate = true;";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnn))
                {
                    SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }

                    await conn.OpenAsync();
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao adicionar: " + ex.Message);
                return false;
            }
        }

        public async Task<List<ColaboradoresResponse>> PesquisarColaboradores(string searchTerm)
        {
            var resultados = new List<ColaboradoresResponse>();

            using (var connection = new SqlConnection("Data Source=localhost;Database=PIM_III;Trusted_Connection=True;Trust Server Certificate=true;"))
            {
                await connection.OpenAsync();

                string query = "SELECT Nome_Completo, Data_Nascimento, CPF, Email FROM Colaborador WHERE Nome_Completo LIKE @searchTerm OR CPF LIKE @searchTerm OR Email LIKE @searchTerm";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var colabViewModel = new ColaboradoresResponse();

                            colabViewModel.Nome_Completo = reader["Nome_Completo"].ToString();
                            colabViewModel.Data_Nascimento = reader["Data_Nascimento"].ToString();
                            colabViewModel.CPF = reader["CPF"].ToString();
                            colabViewModel.Email = reader["Email"].ToString();

                            resultados.Add(colabViewModel);
                        }
                    }
                }
            }

            return resultados;
        }

        public async Task<bool> RemoverColaborador(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                throw new ArgumentNullException(nameof(cpf), "CPF cannot be null or empty.");
            }

            string connectionString = "Data Source=localhost;Database=PIM_III;Trusted_Connection=True;Trust Server Certificate=true;";
            string deleteQuery = "DELETE FROM Colaborador WHERE cpf = @cpf";

            bool success = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                try
                {
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@cpf", cpf);
                        int rowsAffected = await deleteCommand.ExecuteNonQueryAsync();
                        success = rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                   
                    Console.WriteLine($"Error removing collaborator: {ex.Message}");
                    throw; 
                }
            }

            return success;
        }
        public async Task<ColaboradoresResponse> AtualizarColaborador(ColaboradoresResponse response)
        {
            var cnn = "Data Source=localhost;Database=PIM_III;Trusted_Connection=True;Trust Server Certificate=true;";
            using (SqlConnection connection = new SqlConnection(cnn))
            {
                await connection.OpenAsync();

                string sql = "UPDATE Colaborador SET Nome_Completo = @Nome_Completo, Data_Nascimento = @Data_Nascimento, Email = @Email WHERE CPF = @CPF";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome_Completo", response.Nome_Completo);
                    command.Parameters.AddWithValue("@Data_Nascimento", response.Data_Nascimento);
                    command.Parameters.AddWithValue("@Email", response.Email);
              

                    int rowsAffected = await command.ExecuteNonQueryAsync();

                    if (rowsAffected > 0)
                    {
                        return response;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

    }
}

    


