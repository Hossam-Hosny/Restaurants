using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants;

internal class RestaurantsService(IRestaurantsRepository restaurantsRepository
    ,ILogger<RestaurantsService> _logger)
    : IRestaurantsService
{
    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        _logger.LogInformation("Getting all restaurants");
        var restaurants = await restaurantsRepository.GetAllAsync();

       
        return restaurants;
    }

    public async Task<Restaurant?> GetRestaurantByIdD(int id)
    {
        _logger.LogInformation("Getting restaurant with id {id}", id);
        var restaurant = await restaurantsRepository.GetByIdAsync(id);
        return restaurant;
    }
}
