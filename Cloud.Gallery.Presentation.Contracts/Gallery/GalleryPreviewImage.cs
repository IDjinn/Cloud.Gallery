using Cloud.Gallery.Application.Gallery.Common;

namespace Cloud.Gallery.Presentation.Contracts.Gallery;

public record GalleryPreviewImage
{
    public Guid Id { get; init; }
    public byte[] PreviewImageData { get; init; }

    public static implicit operator GalleryPreviewImage(GalleryPreviewImageResult result)
    {
        return new GalleryPreviewImage
        {
            Id = result.Id,
            PreviewImageData = result.PreviewImageData
        };
    }
}