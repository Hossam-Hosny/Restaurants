using Restaurants.Domain.Entities;
using Restaurants.Infrastrucure.Context;

namespace Restaurants.Infrastrucure.Seeders;

internal class RestaurantSeeder(RestaurantDbContext dbContext): IRestaurantSeeder
{

    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Restaurants.Any())
            {
                var restaurants = GetRestaurants();

                dbContext.Restaurants.AddRange(restaurants);
                await dbContext.SaveChangesAsync();


            }
        }
    }


    private IEnumerable<Restaurant> GetRestaurants()
    {
        List<Restaurant> restaurants = [

           new()
            {
                Name = "KFC",
                Category = "Fast Food",
                Description="This is description of Fast Food Restaurant",
                HasDelivery= true,
                Dishes =[
                    new(){
                        Name=" Chicken",
                         Description = "Fired Chicken",
                         Price = 10
                    },
                    new(){
                        Name = "chicken nuggets",
                        Description="chicken nuggets description",
                        Price = 5
                    }
                    ],
                Address = new(){
                    City = "london",
                    Street="Cork st 5",
                    PostalCode = "WC2N 5DU"
                },
                ContactEmail="KFC@gmail.com",
                ContactNumber= "+97568492997"

            },
            new()
            {
                Name = "McDonald",
                Category = "Fast Food",
                Description="This is description of Fast Food Restaurant",
                HasDelivery= true,
                Dishes =[
                    new(){
                        Name=" Burger",
                         Description = "Fired Burger",
                         Price = 11
                    },
                    new(){
                        Name = "chicken nuggets",
                        Description="chicken nuggets description",
                        Price = 6
                    }
                    ],
                Address = new(){
                    City = "New Yourk",
                    Street="Yourk st 5",
                    PostalCode = "M street 5DU"
                },
                ContactEmail="MC@gmail.com",
                ContactNumber= "+97500002997"

            }

           ];
        return restaurants;
    }


} 
