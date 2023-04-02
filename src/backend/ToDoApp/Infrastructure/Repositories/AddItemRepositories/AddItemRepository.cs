using Dapper;
using Entities.UseCases.Items;
using System.Data;

namespace Infrastructure.Repositories.AddItemRepositories
{
    public class AddItemRepository : IAddItemRepository
    {
        private readonly IDbConnection _connection;

        public AddItemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(Item item)
        {
            await _connection.ExecuteAsync("INSERT INTO [dbo].[Item] VALUES (@Name, @Date, @Description, @State)", new
            {
                item.Name,
                item.Date,
                item.Description,
                item.State
            });
        }
    }
}
