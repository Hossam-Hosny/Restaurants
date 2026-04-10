namespace Restaurants.API.Extensions;

public static class WebApplicationExtensions
{
    public static void AddPresentation(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


    }
}
