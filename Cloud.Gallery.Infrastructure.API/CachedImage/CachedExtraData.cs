namespace Cloud.Gallery.Infrastructure.API.CachedImage;

public enum CachedExtraData
{
    None = 0, // do not use it.

    Base64 = 1 << 1,
    Zipped = 2 << 1,

    Encrypted = 3 << 2,
    SHA256 = 3 << 3 | Encrypted,
    SHA384 = 3 << 4 | Encrypted,
}