using Entities.UseCases.GetAllItems;
using Entities.UseCases.Items;
using Infrastructure.Repositories.GetAllItemsRepositories;

namespace Application.UseCases.GetAllItemsUseCase;

public class GetAllItemsUseCase : IGetAllItemsUseCase
{
    private readonly IGetAllItemsRepository _getAllItemsRepository;

    public GetAllItemsUseCase(IGetAllItemsRepository getAllItemsRepository)
    {
        _getAllItemsRepository = getAllItemsRepository;
    }

    public async Task<IEnumerable<Item>> Handle()
    {
        return await _getAllItemsRepository.Execute();
    }
}
