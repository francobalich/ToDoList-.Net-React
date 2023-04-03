using InputPort.UseCases.DeleteItemUseCase;
using InputPort.UseCases.GetItemByIdUseCase;
using OutputPort.Repositories.IDeleteItemRepositories;

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
