namespace Infrastructure.Repositories.DeleteItemRepositories;

public interface IDeleteItemRepository
{
    Task Execute(int id);
}
