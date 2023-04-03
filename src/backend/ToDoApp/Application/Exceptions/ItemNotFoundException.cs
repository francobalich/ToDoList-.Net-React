namespace Application.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(int id)
        {
            Id = id;
        }

        public override string Message => $"The item with id [{Id}] not exists";

        public int Id { get; }
    }
}
