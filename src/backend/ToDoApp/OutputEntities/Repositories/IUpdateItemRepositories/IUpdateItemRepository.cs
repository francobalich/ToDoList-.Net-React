using CoreEntities.Items;

namespace OutputPort.Repositories.IUpdateItemRepositories;

public interface IUpdateItemRepository
{
    Task Execute(Item updatedItem);
}
