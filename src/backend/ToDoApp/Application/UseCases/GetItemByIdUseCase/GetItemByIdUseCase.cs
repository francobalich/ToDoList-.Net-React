using Application.Exceptions;
using Entities.UseCases.GetByIdItemUseCase;
using Entities.UseCases.Items;
using Infrastructure.Repositories.GetItemByIdRepositories;

namespace Application.UseCases.GetItemByIdUseCase;

public class GetItemByIdUseCase : IGetItemByIdUseCase
{
    private readonly IGetItemByIdRepository _getItemByIdRepository;

    public GetItemByIdUseCase(IGetItemByIdRepository getItemByIdRepository)
    {
        _getItemByIdRepository = getItemByIdRepository;
    }

    public async Task<Item> Handle(int id)
    {
        var item = await _getItemByIdRepository.Execute(id);
        return item == default ? throw new ItemNotFoundException(id) : item;
    }
}
