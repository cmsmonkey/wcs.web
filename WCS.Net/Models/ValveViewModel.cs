namespace WCS.Net.Models;

/// <summary>What kind of thing a catalog entry's page is about — drives wording that would
/// otherwise wrongly call an actuator or a whole fuel-gas system a "valve".</summary>
public enum ValveCategory
{
    Valve,
    Actuator,
    System,
}

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
    public required string ShortKicker { get; init; }

    /// <summary>Overrides the page's URL, which otherwise defaults to "/valves/{Slug}" — used when an
    /// entry doesn't belong under the "/valves/" path (e.g. Danfoss's actuator page lives at "/actuators").
    /// Requesting "/valves/{Slug}" for such an entry redirects here instead of rendering directly.</summary>
    public string? RoutePath { get; init; }

    /// <summary>The page's actual URL path — <see cref="RoutePath"/> when set, else "/valves/{Slug}".</summary>
    public string PagePath => RoutePath ?? $"/valves/{Slug}";

    /// <summary>Valve, Actuator, or System (e.g. a fuel-gas supply system) — defaults to Valve since
    /// that's most of the catalog.</summary>
    public ValveCategory Category { get; init; } = ValveCategory.Valve;

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

    /// <summary>Overrides the default "{Name} Service &amp; Spare Parts" H1 — used where that phrasing
    /// doesn't fit (e.g. a fuel-gas supply system page, which isn't itself a spare part).</summary>
    public string? PageHeading { get; init; }

    /// <summary>Names of the seal types WCS sells for this valve. Plain list — no links, prices, or other detail.</summary>
    public required IReadOnlyList<string> SealTypes { get; init; }

    /// <summary>Overrides for the section listing <see cref="SealTypes"/> — default to the generic
    /// "Seal Types &amp; Supplies" / "For {Name}, we supply" wording when unset.</summary>
    public string? SealsSectionKicker { get; init; }
    public string? SealsSectionHeading { get; init; }

    /// <summary>Optional paragraph rendered below the <see cref="SealTypes"/> list.</summary>
    public string? SealsSectionNote { get; init; }

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
