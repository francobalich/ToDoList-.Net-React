using Entities.UseCases.Items;

namespace Entities.UseCases.GetByIdItemUseCase;

public interface IGetItemByIdUseCase
{
    Task<Item> Handle(int id);
}