using Entities.UseCases.Items;

namespace Entities.UseCases.IUpdateItemUseCase;

public interface IUpdateItemUseCase
{
    Task Handle(Item updatedItem);
}