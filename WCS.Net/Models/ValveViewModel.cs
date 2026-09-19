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

public class ValveFaq
{
    public required string Question { get; init; }
    public required string Answer { get; init; }
}

/// <summary>A documented repair, grounded in real before/after photos — not written unless that evidence exists.</summary>
public class ValveCaseStudy
{
    public required string Title { get; init; }
    public required IReadOnlyList<string> Paragraphs { get; init; }
}

public class ValveViewModel
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Kicker { get; init; }

    /// <summary>One-line summary shown on the Home page's valve card.</summary>
    public required string Teaser { get; init; }

    /// <summary>Page &lt;title&gt;. Falls back to a generic "{Name} - World Cryo Services" template when unset.</summary>
    public string? MetaTitle { get; init; }

    /// <summary>Meta description. Falls back to a generic template when unset.</summary>
    public string? MetaDescription { get; init; }
    public required string ThumbnailSrc { get; init; }
    public required string ThumbnailAlt { get; init; }

    public required IReadOnlyList<string> IntroParagraphs { get; init; }
    public required IReadOnlyList<ValvePhoto> Photos { get; init; }

    /// <summary>Names of the seal types WCS sells for this valve. Plain list — no links, prices, or other detail.</summary>
    public required IReadOnlyList<string> SealTypes { get; init; }

    /// <summary>Optional extra callout block rendered below the photo grid (e.g. a related product line).</summary>
    public ValveCallout? Callout { get; init; }

    /// <summary>Frequently asked questions, rendered on the page and as FAQPage JSON-LD.</summary>
    public required IReadOnlyList<ValveFaq> Faqs { get; init; }

    /// <summary>Optional documented repair case studies. Only set where real before/after evidence exists —
    /// most valves currently have placeholder photos and no case study material yet.</summary>
    public IReadOnlyList<ValveCaseStudy> CaseStudies { get; init; } = Array.Empty<ValveCaseStudy>();

    /// <summary>Short paragraph on the OEM manufacturer's own company history — set only where the facts
    /// have been independently verified (not for every valve; e.g. no verifiable source exists for
    /// "Royal Goodwin" as a company).</summary>
    public string? History { get; init; }
}
