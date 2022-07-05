using MediatR;
using Products.Domain;

namespace Products.Application.Products.Commands.Update
{
    public class UpdateProductCommand: ProductReqDto, IRequest<bool>
    {

    }
}
