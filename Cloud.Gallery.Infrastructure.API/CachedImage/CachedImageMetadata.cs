namespace Cloud.Gallery.Infrastructure.API.CachedImage;

public record CachedImageMetadata(
    Guid ImageId,
    string Title,
    string Author,
    string Source,
    CachedExtraData CachedExtraData,
    CachedStorageLocation CachedStorageLocation
);