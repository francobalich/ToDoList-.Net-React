using CoreEntities.Items;

namespace OutputPort.Repositories.IAddItemRepositories;

public interface IAddItemRepository
{
    Task Execute(Item item);
}
