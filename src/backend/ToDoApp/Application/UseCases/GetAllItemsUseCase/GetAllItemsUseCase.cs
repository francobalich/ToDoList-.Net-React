using CoreEntities.Items;
using InputPort.UseCases.GetAllItemsUseCase;
using OutputPort.Repositories.IGetAllItemsRepositories;

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
