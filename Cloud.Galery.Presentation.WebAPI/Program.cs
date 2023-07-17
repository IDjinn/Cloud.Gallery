using Cloud.Galery.Presentation.WebAPI;
using Cloud.Gallery.Application;
using Cloud.Gallery.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddPresentation();

var app = builder.Build();
app.SetupApplication();
app.Run();