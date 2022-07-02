using Microsoft.EntityFrameworkCore;
using Products.Infrastructure;

namespace Products.Api.Infraftracture
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ProductDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));

            return builder.Services;
        }
    }
}
