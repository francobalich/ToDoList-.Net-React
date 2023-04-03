using CoreEntities.Items;

namespace Infrastructure.Repositories.AddItemRepositories;

public interface IAddItemRepository
{
    Task Execute(Item item);
}
