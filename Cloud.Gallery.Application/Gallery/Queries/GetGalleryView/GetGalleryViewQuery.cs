using Cloud.Gallery.Application.Common;
using Cloud.Gallery.Application.Gallery.Common;
using ErrorOr;
using MediatR;

namespace Cloud.Gallery.Application.Gallery.Queries.GetGalleryView;

public record GetGalleryViewQuery : Query, IRequest<ErrorOr<GalleryPreviewResult>>
{
    public override ErrorOr<bool> TryValidate()
    {
        return true;
    }
}