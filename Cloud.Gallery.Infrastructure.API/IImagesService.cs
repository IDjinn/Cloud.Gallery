using Cloud.Gallery.Infrastructure.API.CachedImage;
using Cloud.Gallery.Infrastructure.API.Gallery;
using ErrorOr;

namespace Cloud.Gallery.Infrastructure.API;

public interface IImagesService
{
    public ValueTask<ErrorOr<CachedPreviewImage>> FetchImageAsync(Guid imageId);
    public ValueTask<ErrorOr<CachedImageMetadata>> FetchImageMetadataAsync(Guid imageId);
    public ValueTask<ErrorOr<GalleryCachedPreview>> FetchGalleryCachedViewAsync(Guid userId);
}