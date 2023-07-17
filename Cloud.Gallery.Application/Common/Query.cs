using ErrorOr;

namespace Cloud.Gallery.Application.Common;

public abstract record Query
{
    public abstract ErrorOr<bool> TryValidate();
}