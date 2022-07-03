using MediatR;
using Products.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommand:ProductReqDto,IRequest<ProductResDto>
    {

    }
}
