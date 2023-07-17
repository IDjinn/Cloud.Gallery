using Cloud.Gallery.Infrastructure.API.Image;

namespace Cloud.Gallery.Infrastructure.API.Gallery;

public record GalleryCachedPreviewView(
    ICollection<CachedPreviewImage> Images
    );