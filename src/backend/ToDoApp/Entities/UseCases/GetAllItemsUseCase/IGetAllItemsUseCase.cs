using Entities.UseCases.Items;

namespace Entities.UseCases.GetAllItems;

public interface IGetAllItemsUseCase
{
    Task<IEnumerable<Item>> Handle();
}