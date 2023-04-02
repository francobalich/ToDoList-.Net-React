using Entities.UseCases.GetByIdItemUseCase;
using Entities.UseCases.Items;
using Entities.UseCases.IUpdateItemUseCase;
using Infrastructure.Repositories.UpdateItemRepositories;

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
