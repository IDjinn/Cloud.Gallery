using Cloud.Gallery.Presentation.Contracts.Image;

namespace Cloud.Gallery.Presentation.Contracts;

public readonly record struct ImageMetadata(
    Guid ImageId,
    string Title,
    string Author,
    string Source,
    ExtraMetadata ExtraMetadata,
    StorageType StorageType
    );