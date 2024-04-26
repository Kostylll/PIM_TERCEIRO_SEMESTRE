using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using PimProject.Application.Domain.Aggregates;
using PimProject.Application.Domain.Interface;
using PimProject.Application.Domain.Response;
using PimProject.Application.Infra.Data.DBContext;
using PimProject.Application.Infra.Data.Repository;
using System;
using System.Collections.Generic;
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
            string sqlCommand = "INSERTO INTO Colaboradores (Nome, Sobrenome, Data_Nascimento, CPF, Email) VALUES (@Nome, @Sobrenome, @Data_Nascimento, @CPF, @Email)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Nome", response.Nome },
                { "@Sobrenome", response.Sobrenome },
                { "@Data_Nascimento", response.Data_Nascimento },
                { "@CPF", response.CPF },
                { "@Email", response.Email }

            };
            return await AdicionarAsync(sqlCommand, parameters);
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
    }

}

