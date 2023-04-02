namespace Entities.UseCases.DeleteItemUseCase;

public interface IDeleteItemUseCase
{
    Task Handle(int id);
}