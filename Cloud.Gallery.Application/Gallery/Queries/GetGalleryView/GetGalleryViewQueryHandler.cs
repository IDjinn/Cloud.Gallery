using Cloud.Gallery.Application.Gallery.Common;
using Cloud.Gallery.Infrastructure.API;
using ErrorOr;
using MediatR;

namespace Cloud.Gallery.Application.Gallery.Queries.GetGalleryView;

public class GetGalleryViewQueryHandler : IRequestHandler<GetGalleryViewQuery, ErrorOr<GalleryPreviewResult>>
{
    private readonly IEnumerable<IImagesService> _imagesServices;

    public GetGalleryViewQueryHandler(IEnumerable<IImagesService> imagesServices)
    {
        _imagesServices = imagesServices;
    }

    public async Task<ErrorOr<GalleryPreviewResult>> Handle(GetGalleryViewQuery request,
        CancellationToken cancellationToken)
    {
        var some = await _imagesServices.First().FetchGalleryCachedViewAsync(Guid.Empty);

        await Task.CompletedTask;
        return new GalleryPreviewResult(
            new[] { new GalleryPreviewImageResult(Guid.Empty, some.Value.Images.First().PreviewData) }
        );
    }
}