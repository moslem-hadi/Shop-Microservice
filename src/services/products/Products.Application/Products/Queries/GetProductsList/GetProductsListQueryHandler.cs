﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Products.Domain;
using Products.Domain.Base;

namespace Products.Application.Products.Queries.GetProductsList
{
    internal class GetProductsListQueryHandler:IRequestHandler<GetProductsListQuery, PaginationResDto<List<ProductResDto>>>
    {

        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
        }
        public async Task<PaginationResDto<List<ProductResDto>>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var productList = await _readUnitOfWork.ProductReadRepository.GetByFilterPagedAsync(request);
            PaginationResDto<List<ProductResDto>> result = new PaginationResDto<List<ProductResDto>>
            {
                Data = _mapper.Map<List<ProductResDto>>(productList.Item1),
                TotalCount = productList.Item2,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize

            };

            return result;
        }
    }
}
