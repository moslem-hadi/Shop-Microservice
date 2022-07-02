namespace Products.Domain
{
    public interface IWriteUnitOfWork
    {
        IProductWriteRepository ProductWriteRepository { get; }
    }
}
