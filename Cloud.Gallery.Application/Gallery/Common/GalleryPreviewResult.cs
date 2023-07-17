namespace Cloud.Gallery.Application.Gallery.Common;

public readonly record struct GalleryPreviewResult(
    ICollection<GalleryPreviewImageResult> PreviewImages
);