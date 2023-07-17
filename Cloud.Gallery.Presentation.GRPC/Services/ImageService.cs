using Cloud.Gallery.Infrastructure.API;
using Grpc.Core;

namespace Cloud.Gallery.Presentation.GRPC.Services;

public class ImageService : GRPC.ImageService.ImageServiceBase
{
    private readonly IEnumerable<IImagesService> _imagesServices;

    public ImageService(IEnumerable<IImagesService> imagesServices)
    {
        _imagesServices = imagesServices;
    }

    public override Task<FetchImageResponse> FetchImage(FetchImageRequest request, ServerCallContext context)
    {
        return base.FetchImage(request, context);
    }

    public override async Task<FetchGalleryCacheResponse> FetchGalleryCache(FetchGalleryCacheRequest request,
        ServerCallContext context)
    {
        await _imagesServices.First().FetchGalleryCachedViewAsync(Guid.Empty);
        return new FetchGalleryCacheResponse();
    }
}