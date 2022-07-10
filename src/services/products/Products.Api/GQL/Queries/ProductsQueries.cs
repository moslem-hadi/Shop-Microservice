using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Queries.GetProductsList;

namespace Products.Api.GQL.Queries
{
    public static class ProductsQueries
    {
        public static  void ProductQueries(this ObjectGraphType schema,IMediator mediator)
        {
            schema.Field<ListGraphType<ProductResType>>(
                "getProducts",
                description: "return list of prdoucts",
                resolve: context => {
                    try
                    {
                        return mediator.Send(new GetProductsListQuery());
                    }
                    catch (Exception ex)
                    {
                        context.Errors.Add(new ExecutionError(ex.Message));
                        return null;
                    }
                }

            );
            schema.FieldAsync<PaginationResType<ListGraphType<ProductResType>>>(
                "getProductsByFilter",
                description: "return list of filtered prdoucts",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductFilterType>> { Name = "filter" }),


                resolve: async context =>
                {
                    var filterParams = context.GetArgument<GetProductsListQuery>("filter");
                    var res = await mediator.Send(filterParams);

                    return res;
                });
        }
    }
}
