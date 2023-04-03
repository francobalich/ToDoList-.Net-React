using CoreEntities.Items;

namespace OutputPort.Repositories.IGetAllItemsRepositories;

public interface IGetAllItemsRepository
{
    Task<IEnumerable<Item>> Execute();
}
