namespace Products.Domain
{
    public interface IReadUnitOfWork
    {
        IProductReadRepository ProductReadRepository { get; }
    }
}
