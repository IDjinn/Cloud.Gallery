namespace Cloud.Galery.Presentation.WebAPI;

public static class DependencyInjector
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }


    public static WebApplication SetupApplication(this WebApplication app)
    {
        app.UseExceptionHandler("/error");
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        return app;
    }
}