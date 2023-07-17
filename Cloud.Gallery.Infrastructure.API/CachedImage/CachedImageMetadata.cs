namespace Cloud.Gallery.Infrastructure.API.CachedImage;

public record ImageMetadata(
    Guid ImageId,
    string Title,
    string Author,
    string Source,
    ExtraData ExtraData,
    StorageLocation StorageLocation
    );