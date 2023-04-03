using CoreEntities.Items;
using Dapper;
using System.Data;

namespace Infrastructure.Repositories.GetAllItemsRepositories
{
    public class GetAllItemsRepository : IGetAllItemsRepository
    {
        private readonly IDbConnection _connection;

        public GetAllItemsRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<Item>> Execute()
        {
            return await _connection.QueryAsync<Item>(
                "SELECT [Id],[Name],[Date],[Description],[State] " +
                "FROM [dbo].[Item]");
        }
    }
}
