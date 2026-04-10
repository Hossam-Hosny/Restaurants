using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;
using Restaurants.Infrastrucure.Context;

namespace Restaurants.Infrastrucure.Repositories;

internal class RestaurantsRepository(RestaurantDbContext dbContext) 
    : IRestaurantsRepository
{
    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
        var restaurants = await dbContext.Restaurants.ToListAsync();
        return restaurants;

    }
}
