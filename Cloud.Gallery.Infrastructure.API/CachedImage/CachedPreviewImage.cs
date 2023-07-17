namespace Cloud.Gallery.Infrastructure.API.Image;

public record CachedPreviewImage(
    Guid Id, 
    byte[] PreviewData
);