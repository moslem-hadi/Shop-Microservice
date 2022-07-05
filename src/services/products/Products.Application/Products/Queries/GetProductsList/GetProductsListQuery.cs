using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Products.Domain;
using Products.Domain.Base;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery: ProductFilterPageReqDto, IRequest<PaginationResDto<List<ProductResDto>>>
    {
     
    }
}
