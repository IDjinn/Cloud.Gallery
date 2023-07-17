using System.Diagnostics;
using System.Reflection;
using Cloud.Gallery.Infrastructure.API;
using Cloud.Gallery.Infrastructure.API.CachedImage;
using Cloud.Gallery.Infrastructure.API.Gallery;
using ErrorOr;

namespace Cloud.Gallery.Infrastructure.Images;

public class LocalImagesService : IImagesService
{
    private static readonly string PreviewFolder =
        $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/images/preview";

    private static readonly string ImageFolder =
        $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}/images/cache";

    public LocalImagesService()
    {
        if (!Directory.Exists(PreviewFolder))
            Directory.CreateDirectory(PreviewFolder);
        if (!Directory.Exists(ImageFolder))
            Directory.CreateDirectory(ImageFolder);
    }

    public async ValueTask<ErrorOr<CachedPreviewImage>> FetchImageAsync(Guid imageId)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<ErrorOr<CachedImageMetadata>> FetchImageMetadataAsync(Guid imageId)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<ErrorOr<GalleryCachedPreview>> FetchGalleryCachedViewAsync(Guid userId)
    {
        var path = $"{PreviewFolder}/{userId}";
        Debug.Assert(Path.Exists(path), "Path.Exists(path) to fetch images.");

        var images = new List<CachedPreviewImage>();
        foreach (var imagePath in Directory.GetFiles(path))
        {
            var imageId = Guid.NewGuid();
            var data = await File.ReadAllBytesAsync(imagePath);
            images.Add(new CachedPreviewImage(imageId, data));
        }

        Debug.Assert(images.Any(), "Images folder must have images to test.");
        return new GalleryCachedPreview(images);
    }
}