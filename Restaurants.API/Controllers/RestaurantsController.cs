using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;

namespace Restaurants.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController(IRestaurantsService restaurantsService):ControllerBase
{

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        var restaurants = await restaurantsService.GetAllRestaurants();
        return Ok(restaurants);
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var restaurant = await restaurantsService.GetRestaurantByIdD(id);
        if (restaurant == null)
            return NotFound();
      
        return Ok(restaurant);
    }


}
