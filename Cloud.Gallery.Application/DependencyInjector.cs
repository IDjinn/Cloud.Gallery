using Microsoft.Extensions.DependencyInjection;

namespace Cloud.Gallery.Application;

public static class DependencyInjector
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssemblyContaining(typeof(DependencyInjector));
        });
        return services;
    }
}