using CoreEntities.Items;

namespace Entities.UseCases.IUpdateItemUseCase;

public interface IUpdateItemUseCase
{
    Task Handle(Item updatedItem);
}