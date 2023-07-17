namespace Cloud.Gallery.Presentation.Contracts;

public readonly record struct GalleryImageCache(
    Guid Id,
    byte[] PreviewData
    );