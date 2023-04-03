using CoreEntities.Items;

namespace Infrastructure.Repositories.GetAllItemsRepositories;

public interface IGetAllItemsRepository
{
    Task<IEnumerable<Item>> Execute();
}
