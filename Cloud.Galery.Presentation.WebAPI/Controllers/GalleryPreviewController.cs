using Cloud.Galery.Presentation.WebAPI.Controllers.Common;
using Cloud.Gallery.Application.Gallery.Queries.GetGalleryView;
using Cloud.Gallery.Presentation.Contracts.Gallery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cloud.Galery.Presentation.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GalleryPreviewController : ApiController<GalleryPreviewResponse>
{
    private readonly ISender _mediator;

    public GalleryPreviewController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GalleryPreviewRequest()
    {
        var query = new GetGalleryViewQuery(); //(GetGalleryViewQuery)request;
        var result = await _mediator.Send(query);

        return result.Match(Ok, Problem);
    }
}