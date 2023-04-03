using CoreEntities.Items;

namespace InputPort.UseCases.UpdateItemUseCase;

public interface IUpdateItemUseCase
{
    Task Handle(Item updatedItem);
}