using CoreEntities.Items;

namespace InputPort.UseCases.AddItemUseCase;

public interface IAddItemUseCase
{
    Task Handle(Item item);
}
