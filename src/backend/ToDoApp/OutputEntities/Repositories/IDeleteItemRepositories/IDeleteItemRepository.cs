namespace OutputPort.Repositories.IDeleteItemRepositories;

public interface IDeleteItemRepository
{
    Task Execute(int id);
}
