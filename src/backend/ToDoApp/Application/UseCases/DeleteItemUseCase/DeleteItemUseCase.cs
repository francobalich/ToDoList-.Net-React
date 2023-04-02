using Entities.UseCases.DeleteItemUseCase;
using Entities.UseCases.GetByIdItemUseCase;
using Infrastructure.Repositories.DeleteItemRepositories;

namespace Application.UseCases.DeleteItemUseCase;

public class DeleteItemUseCase : IDeleteItemUseCase
{
    private readonly IDeleteItemRepository _deleteItemRepository;
    private readonly IGetItemByIdUseCase _getItemByIdUseCase;

    public DeleteItemUseCase(IDeleteItemRepository deleteItemRepository, IGetItemByIdUseCase getItemByIdUseCase)
    {
        _deleteItemRepository = deleteItemRepository;
        _getItemByIdUseCase = getItemByIdUseCase;
    }

    public async Task Handle(int id)
    {
        await _getItemByIdUseCase.Handle(id);
        await _deleteItemRepository.Execute(id);
    }
}
