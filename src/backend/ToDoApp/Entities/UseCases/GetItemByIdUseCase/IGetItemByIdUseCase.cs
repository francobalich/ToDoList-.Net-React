using CoreEntities.Items;

namespace Entities.UseCases.GetByIdItemUseCase;

public interface IGetItemByIdUseCase
{
    Task<Item> Handle(int id);
}