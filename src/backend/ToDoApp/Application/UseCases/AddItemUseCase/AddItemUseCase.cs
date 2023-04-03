using CoreEntities.Items;
using InputPort.UseCases.AddItemUseCase;
using OutputPort.Repositories.IAddItemRepositories;

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