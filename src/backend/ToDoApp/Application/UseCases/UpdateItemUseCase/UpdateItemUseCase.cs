using CoreEntities.Items;
using InputPort.UseCases.GetItemByIdUseCase;
using InputPort.UseCases.UpdateItemUseCase;
using OutputPort.Repositories.IUpdateItemRepositories;

namespace Application.UseCases.UpdateItemUseCase;

public class UpdateItemUseCase : IUpdateItemUseCase
{
    private readonly IUpdateItemRepository _updateItemRepository;
    private readonly IGetItemByIdUseCase _getItemByIdUseCase;

    public UpdateItemUseCase(IUpdateItemRepository updateItemRepository, IGetItemByIdUseCase getItemByIdUseCase)
    {
        _updateItemRepository = updateItemRepository;
        _getItemByIdUseCase = getItemByIdUseCase;
    }

    public async Task Handle(Item updatedItem)
    {
        await _getItemByIdUseCase.Handle(updatedItem.Id);
        await _updateItemRepository.Execute(updatedItem);
    }
}
