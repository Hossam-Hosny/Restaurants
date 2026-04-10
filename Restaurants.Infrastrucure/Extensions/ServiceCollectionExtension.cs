using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastrucure.Context;
using Restaurants.Infrastrucure.Repositories;
using Restaurants.Infrastrucure.Seeders;

namespace Restaurants.Infrastrucure.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddInfrastrucure(this IServiceCollection services , IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");


        services.AddDbContext<RestaurantDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });


        services.AddScoped<IRestaurantSeeder, RestaurantSeeder>();
        services.AddScoped<IRestaurantsRepository, RestaurantsRepository>();




    }
}
