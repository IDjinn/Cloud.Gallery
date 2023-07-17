using Cloud.Gallery.Application.Gallery.Common;

namespace Cloud.Gallery.Presentation.Contracts.Gallery;

public readonly record struct GalleryPreviewResponse(ICollection<GalleryPreviewImage> PreviewImages)
{
    public static implicit operator GalleryPreviewResponse(GalleryPreviewResult result)
    {
        return new GalleryPreviewResponse
        {
            PreviewImages = result.PreviewImages.Select(image => (GalleryPreviewImage)image).ToList()
        };
    }
}