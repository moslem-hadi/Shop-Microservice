using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Products.Application.Behaviours;
using Products.Domain;
using Products.Infrastructure;
using System.Text.Json.Serialization;

namespace Products.Api.Infrastructure
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder.Services;
        }
        public static IServiceCollection AddInfrastructureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ProductDbContext>(option =>
                option.UseNpgsql(builder.Configuration.GetConnectionString("ProductDbConn")));
            builder.Services.AddScoped<IWriteUnitOfWork, WriteUnitOfWork>();
            builder.Services.AddScoped<IReadUnitOfWork, ReadUnitOfWork>();
            builder.Services.AddAutoMapper(Assemblies.InfrastructureAssembly);

            return builder.Services;
        }

        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddValidatorsFromAssemblies(new List<System.Reflection.Assembly> { Assemblies.ApplicationAssembly});
            builder.Services.AddMediatR(Assemblies.ApplicationAssembly);

            //for exception throwing
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return builder.Services;
        }
    }
}
