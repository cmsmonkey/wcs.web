namespace WCS.Net.Models;

public class ValvePhoto
{
    public required string Src { get; init; }
    public required string Alt { get; init; }
    public string? Caption { get; init; }
}

public class ValveCallout
{
    public string? Kicker { get; init; }
    public required string Title { get; init; }
    public required string Body { get; init; }
}

public class ValveViewModel
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Kicker { get; init; }

    /// <summary>One-line summary shown on the Home page's valve card.</summary>
    public required string Teaser { get; init; }
    public required string ThumbnailSrc { get; init; }
    public required string ThumbnailAlt { get; init; }

    public required IReadOnlyList<string> IntroParagraphs { get; init; }
    public required IReadOnlyList<ValvePhoto> Photos { get; init; }

    /// <summary>Optional extra callout block rendered below the photo grid (e.g. a related product line).</summary>
    public ValveCallout? Callout { get; init; }
}
