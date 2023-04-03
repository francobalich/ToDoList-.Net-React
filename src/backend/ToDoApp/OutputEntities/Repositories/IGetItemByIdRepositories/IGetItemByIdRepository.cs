using CoreEntities.Items;

namespace OutputPort.Repositories.IGetItemByIdRepositories;

public interface IGetItemByIdRepository
{
    Task<Item> Execute(int id);
}
