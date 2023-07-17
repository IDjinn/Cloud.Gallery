namespace Cloud.Gallery.Application.Gallery.Common;

public record GalleryPreviewImageResult(
    Guid Id,
    byte[] PreviewImageData
);