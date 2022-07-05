using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Delete;
using Products.Application.Products.Commands.Update;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain;
using Products.Domain.Base;

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IMapper _mapper { get; }
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMediator _mediator;

        public ProductsController(IReadUnitOfWork readUnitOfWork, IMapper mapper, IMediator mediatr)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
            _mediator = mediatr;
        }


        [HttpGet]
        public async Task<PaginationResDto<List<ProductResDto>>> Get()
        {
            //return _mapper.Map<List<ProductResDto>>(await _readUnitOfWork.ProductReadRepository.GetAllAsync());
            return await _mediator.Send(new GetProductsListQuery());
        }
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand model)
        {
            return await _mediator.Send(model);
        }


        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
        {
            if (id != request.Id)
            {

                return BadRequest("Id in body and query must be equal");
            }
            var res = await _mediator.Send(request);
            return res;

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }
    }
}
