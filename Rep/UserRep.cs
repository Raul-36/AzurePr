using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AzurePr.Models;
using Dapper;

namespace AzurePr.Rep
{
    public class UserRep
    {
        private readonly string conectString ="Server=tcp:azureprsdevdb.database.windows.net,1433;Initial Catalog=AzurePrRgDevDb;Persist Security Info=False;User ID=Admin1;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    
        public async Task<IEnumerable<User>> GetAll() {
            var connection = new SqlConnection(conectString);
            return await connection.QueryAsync<User>("select * from Uses");
        }
        public async Task Create(User user) {
            var connection = new SqlConnection(conectString);
            await connection.ExecuteAsync("insert into Users (Name) values(@name)",user);
        }
        public async Task Update(User user) {
            var connection = new SqlConnection(conectString);
            await connection.ExecuteAsync(@"UPDATE User
SET Name = @name
WHERE Id = @id;",user);
        }
        public async Task Delete(int id) {
            var connection = new SqlConnection(conectString);
            await connection.ExecuteAsync("DELETE FROM Users WHERE Id = @id;",id);
        }
    
    }
}