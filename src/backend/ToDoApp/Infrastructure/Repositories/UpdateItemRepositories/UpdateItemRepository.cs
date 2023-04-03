using CoreEntities.Items;
using Dapper;
using System.Data;

namespace Infrastructure.Repositories.UpdateItemRepositories
{
    public class UpdateItemRepository : IUpdateItemRepository
    {
        private readonly IDbConnection _connection;

        public UpdateItemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task Execute(Item updatedItem)
        {
            await _connection.ExecuteAsync(
                "UPDATE [dbo].[Item] " +
                "SET [Name] = @name, [Date] = @date, [Description] = @description, [State] = @state " +
                "WHERE id = @id", 
            new
            {
                updatedItem.Id,
                updatedItem.Name,
                updatedItem.Description,
                updatedItem.Date,
                updatedItem.State
            });
        }
    }
}
