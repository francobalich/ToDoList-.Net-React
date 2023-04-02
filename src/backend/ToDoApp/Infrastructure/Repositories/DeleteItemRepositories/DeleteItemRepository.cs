using Dapper;
using System.Data;

namespace Infrastructure.Repositories.DeleteItemRepositories
{
    public class DeleteItemRepository : IDeleteItemRepository
    {
        private readonly IDbConnection _connection;

        public DeleteItemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(int id)
        {
            await _connection.ExecuteAsync("DELETE FROM [dbo].[Item] WHERE Id = @id", new
            {
                id
            });
        }
    }
}
