using CoreEntities.Items;

namespace InputPort.UseCases.GetAllItemsUseCase;

public interface IGetAllItemsUseCase
{
    Task<IEnumerable<Item>> Handle();
}