using Cloud.Gallery.Infrastructure.API;
using Cloud.Gallery.Infrastructure.Images;
using Microsoft.Extensions.DependencyInjection;

namespace Cloud.Gallery.Infrastructure;

public static class DependencyInjector
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IImagesService, LocalImagesService>();
        return services;
    }
}