using Cloud.Gallery.Infrastructure;
using Cloud.Gallery.Presentation.GRPC.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddInfrastructure()
    .AddGrpc();

var app = builder.Build();
app.MapGrpcService<ImageService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
app.Run();