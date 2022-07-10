using Products.Api.GQL;
using Products.Api.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();
builder.AddInfrastructureServices();
builder.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");
app.UseAuthorization();

app.MapControllers();

app.Run();
