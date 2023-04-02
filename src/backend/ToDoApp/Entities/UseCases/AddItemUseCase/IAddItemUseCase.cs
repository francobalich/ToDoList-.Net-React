using Entities.UseCases.Items;

namespace Entities.UseCases.AddItemUseCase;

public interface IAddItemUseCase
{
    Task Handle(Item item);
}
