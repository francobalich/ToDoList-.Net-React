using CoreEntities.Items;
using Entities.UseCases.AddItemUseCase;
using Infrastructure.Repositories.AddItemRepositories;

namespace Application.UseCases.AddItemUseCase;

public class AddItemUseCase : IAddItemUseCase
{
    private readonly IAddItemRepository _addItemRepository;

    public AddItemUseCase(IAddItemRepository addItemRepository)
    {
        _addItemRepository = addItemRepository;
    }

    public async Task Handle(Item item)
    {
        await _addItemRepository.Execute(item);
    }
}