using Restaurants.API.Extensions;
using Restaurants.Application.Extensions;
using Restaurants.Infrastrucure.Extensions;
using Restaurants.Infrastrucure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();




builder.AddPresentation();
builder.Services.AddApplication();
builder.Services.AddInfrastrucure(builder.Configuration);







var app = builder.Build();

var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<IRestaurantSeeder>();
await seeder.Seed();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
