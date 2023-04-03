using CoreEntities.Items;

namespace InputPort.UseCases.GetItemByIdUseCase;

public interface IGetItemByIdUseCase
{
    Task<Item> Handle(int id);
}