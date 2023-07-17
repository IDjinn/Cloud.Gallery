using Cloud.Gallery.Application.Gallery.Queries.GetGalleryView;

namespace Cloud.Gallery.Presentation.Contracts.Gallery;

public readonly record struct GalleryPreviewRequest(Guid None)
{
    public static explicit operator GetGalleryViewQuery(GalleryPreviewRequest request)
    {
        return new GetGalleryViewQuery();
    }
}