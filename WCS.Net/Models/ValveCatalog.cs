namespace WCS.Net.Models;

// TODO: replace the placeholder Name/Kicker/IntroParagraphs/Photos below with the
// real copy and photos for each valve type once they're ready.
public static class ValveCatalog
{
    public static readonly IReadOnlyList<ValveViewModel> All = new[]
    {
        new ValveViewModel
        {
            Slug = "valve-a",
            Name = "Valve A",
            Kicker = "Valve Type",
            IntroParagraphs = new[]
            {
                "Placeholder: a short description of what type of valve \"Valve A\" is " +
                "(e.g. brand, size range, and where it's typically installed on an LNG carrier).",
                "Placeholder: a short description of how WCS services this valve type " +
                "— overhaul, spare parts, or both — and what makes WCS's approach different.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/valve-a/photo-1.svg", Alt = "Placeholder photo of Valve A, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-a/photo-2.svg", Alt = "Placeholder photo of Valve A, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-a/photo-3.svg", Alt = "Placeholder photo of Valve A, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/valve-a/photo-4.svg", Alt = "Placeholder photo of Valve A, 4 of 4" },
            },
        },
        new ValveViewModel
        {
            Slug = "valve-b",
            Name = "Valve B",
            Kicker = "Valve Type",
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
        },
    };

    public static ValveViewModel? FindBySlug(string slug) =>
        All.FirstOrDefault(v => string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
