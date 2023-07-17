using Cloud.Gallery.Infrastructure.API.CachedImage;

namespace Cloud.Gallery.Infrastructure.API.Gallery;

public record GalleryCachedPreview(
    ICollection<CachedPreviewImage> Images
);