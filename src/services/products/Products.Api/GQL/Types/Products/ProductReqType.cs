using GraphQL.Types;

namespace Products.Api.GQL.Types.Products
{
    public class ProductReqType : InputObjectGraphType
    {
        public ProductReqType()
        {
            Name = nameof(ProductReqType);
            Field<IdGraphType>("Id");
            Field<BooleanGraphType>("Active");
            Field<StringGraphType>("Title");
            Field<StringGraphType>("Description");

            Field<StringGraphType>("ImageUrl");
            Field<DecimalGraphType>("Price");

            Field<StringGraphType>("Code");
            Field<StringGraphType>("Link");
            Field<IntGraphType>("CategoryId");
        }
    }
}
