namespace WCS.Net.Models;

// TODO: replace the placeholder Name/Kicker/Teaser/IntroParagraphs/Photos below with the
// real copy and photos for each valve type once they're ready. The real HQ/Acto parts
// photos (moved off the Home page) landed on Valve A, and the LPG seals callout landed
// on Valve B — pure guesses on our part since "Valve A/B/C/D" aren't real valve type
// names yet. Re-assign them once the real valve identities are decided.
public static class ValveCatalog
{
    public static readonly IReadOnlyList<ValveViewModel> All = new[]
    {
        new ValveViewModel
        {
            Slug = "valve-a",
            Name = "Valve A",
            Kicker = "Valve Type",
            Teaser = "Placeholder teaser — one-line summary of what Valve A is and who services it.",
            ThumbnailSrc = "/images/valves/valve-a/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Valve A",
            IntroParagraphs = new[]
            {
                "Placeholder: a short description of what type of valve \"Valve A\" is " +
                "(e.g. brand, size range, and where it's typically installed on an LNG carrier).",
                "Placeholder: a short description of how WCS services this valve type " +
                "— overhaul, spare parts, or both — and what makes WCS's approach different.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-before.jpg", Alt = "A worn HQ limitswitch box after years of service", Caption = "HQ LIMITSWITCH BOX — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-after.jpg", Alt = "A 316L stainless steel limitswitch box manufactured by WCS", Caption = "316L STAINLESS STEEL LIMITSWITCH BOX — WCS" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-before.jpg", Alt = "A worn Acto distribution bar, corroded", Caption = "ACTO DISTRIBUTION BAR — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-after.jpg", Alt = "A newly machined Acto distribution bar manufactured by WCS", Caption = "ACTO DISTRIBUTION BAR — WCS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-1.jpg", Alt = "HQ and Acto cylinder seal kit, assembled", Caption = "HQ & ACTO CYLINDER SEAL KITS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-2.jpg", Alt = "HQ and Acto cylinder seal kit, alternate", Caption = "HQ 400 CYLINDERS — MORE SIZES IN PROGRESS" },
                new ValvePhoto { Src = "/images/parts/hydraulic-block-blind-plug.jpg", Alt = "HQ hydraulic block blind plug", Caption = "HQ HYDRAULIC BLOCK BLIND PLUG" },
            },
        },
        new ValveViewModel
        {
            Slug = "valve-b",
            Name = "Valve B",
            Kicker = "Valve Type",
            Teaser = "Placeholder teaser — one-line summary of what Valve B is and who services it.",
            ThumbnailSrc = "/images/valves/valve-b/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Valve B",
            IntroParagraphs = new[]
            {
                "Placeholder: a short description of what type of valve \"Valve B\" is " +
                "(e.g. brand, size range, and where it's typically installed on an LNG carrier).",
                "Placeholder: a short description of how WCS services this valve type " +
                "— overhaul, spare parts, or both — and what makes WCS's approach different.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/valve-b/photo-1.svg", Alt = "Placeholder photo of Valve B, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-b/photo-2.svg", Alt = "Placeholder photo of Valve B, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-b/photo-3.svg", Alt = "Placeholder photo of Valve B, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-b/photo-4.svg", Alt = "Placeholder photo of Valve B, 4 of 4" },
            },
            Callout = new ValveCallout
            {
                Kicker = "New",
                Title = "LPG seals, now available from WCS",
                Body = "Following repeated requests from customers, WCS now supplies LPG seals for Klinger Westad " +
                       "valves — designed as a direct, fully compatible OEM replacement. We're building stock of " +
                       "the most common sizes for shorter lead times and fast worldwide delivery. The 25% Price " +
                       "Guarantee applies here too.",
            },
        },
        new ValveViewModel
        {
            Slug = "valve-c",
            Name = "Valve C",
            Kicker = "Valve Type",
            Teaser = "Placeholder teaser — one-line summary of what Valve C is and who services it.",
            ThumbnailSrc = "/images/valves/valve-c/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Valve C",
            IntroParagraphs = new[]
            {
                "Placeholder: a short description of what type of valve \"Valve C\" is " +
                "(e.g. brand, size range, and where it's typically installed on an LNG carrier).",
                "Placeholder: a short description of how WCS services this valve type " +
                "— overhaul, spare parts, or both — and what makes WCS's approach different.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/valve-c/photo-1.svg", Alt = "Placeholder photo of Valve C, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-c/photo-2.svg", Alt = "Placeholder photo of Valve C, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-c/photo-3.svg", Alt = "Placeholder photo of Valve C, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-c/photo-4.svg", Alt = "Placeholder photo of Valve C, 4 of 4" },
            },
        },
        new ValveViewModel
        {
            Slug = "valve-d",
            Name = "Valve D",
            Kicker = "Valve Type",
            Teaser = "Placeholder teaser — one-line summary of what Valve D is and who services it.",
            ThumbnailSrc = "/images/valves/valve-d/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Valve D",
            IntroParagraphs = new[]
            {
                "Placeholder: a short description of what type of valve \"Valve D\" is " +
                "(e.g. brand, size range, and where it's typically installed on an LNG carrier).",
                "Placeholder: a short description of how WCS services this valve type " +
                "— overhaul, spare parts, or both — and what makes WCS's approach different.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/valve-d/photo-1.svg", Alt = "Placeholder photo of Valve D, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-d/photo-2.svg", Alt = "Placeholder photo of Valve D, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-d/photo-3.svg", Alt = "Placeholder photo of Valve D, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-d/photo-4.svg", Alt = "Placeholder photo of Valve D, 4 of 4" },
            },
        },
    };

    public static ValveViewModel? FindBySlug(string slug) =>
        All.FirstOrDefault(v => string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
