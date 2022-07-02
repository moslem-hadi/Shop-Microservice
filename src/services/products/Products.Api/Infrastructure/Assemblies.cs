using Products.Domain;
using Products.Infrastructure;
using System.Reflection;

namespace Products.Api.Infrastructure
{
    public static class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Product).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(ProductDbContext).Assembly;
    }
}
