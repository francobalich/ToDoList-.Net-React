using Entities.UseCases.Items;

namespace Infrastructure.Repositories.GetAllItemsRepositories;

public interface IGetAllItemsRepository
{
    Task<IEnumerable<Item>> Execute();
}
