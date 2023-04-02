using Dapper;
using Entities.UseCases.Items;
using System.Data;

namespace Infrastructure.Repositories.GetItemByIdRepositories
{
    public class GetItemByIdRepository : IGetItemByIdRepository
    {
        private readonly IDbConnection _connection;

        public GetItemByIdRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<Item> Execute(int id)
        {
            return await _connection.QuerySingleOrDefaultAsync<Item>("SELECT [Id],[Name],[Date],[Description],[State] FROM [dbo].[Item] WHERE Id = @id", new
            {
                id
            });
        }
    }
}
