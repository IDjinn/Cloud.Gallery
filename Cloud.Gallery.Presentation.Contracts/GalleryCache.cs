namespace Cloud.Gallery.Presentation.Contracts;

public readonly record struct GalleryCache(ICollection<GalleryImageCache> Images);