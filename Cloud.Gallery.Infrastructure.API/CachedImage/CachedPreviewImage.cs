namespace Cloud.Gallery.Infrastructure.API.CachedImage;

public record CachedPreviewImage(
    Guid Id,
    byte[] PreviewData
);