using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class Repositorio
    {
        private readonly string _connectionString;

        public Repositorio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InserirAsync(IEnumerable<Pessoa> pessoas)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                await connection.InsertAsync(pessoas);
            }
        }
    }
}
