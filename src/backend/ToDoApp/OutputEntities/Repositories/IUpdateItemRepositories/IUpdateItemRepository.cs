using CoreEntities.Items;

namespace Infrastructure.Repositories.UpdateItemRepositories;

public interface IUpdateItemRepository
{
    Task Execute(Item updatedItem);
}
