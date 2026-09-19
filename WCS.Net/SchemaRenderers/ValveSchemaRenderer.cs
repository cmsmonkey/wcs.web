using System.Text.Json;
using WCS.Net.Models;

namespace WCS.Net.SchemaRenderers;

/// <summary>Renders a valve page's JSON-LD: a Service listing the seal types as an offer catalog, plus a
/// BreadcrumbList. Provider links to the Organization block by @id instead of repeating org details.</summary>
public static class ValveSchemaRenderer
{
    private const string SiteUrl = "https://www.wcryoservices.com";

    private static readonly JsonSerializerOptions Options = new() { WriteIndented = false };

    public static string Render(ValveViewModel valve)
    {
        var pageUrl = $"{SiteUrl}/valves/{valve.Slug}";

        var service = new Dictionary<string, object?>
        {
            ["@context"] = "https://schema.org",
            ["@type"] = "Service",
            ["serviceType"] = "Valve spare parts and service",
            ["name"] = $"{valve.Name} Spare Parts & Service",
            ["description"] = valve.MetaDescription ?? valve.Teaser,
            ["url"] = pageUrl,
            ["areaServed"] = "Worldwide",
            ["provider"] = new Dictionary<string, object?> { ["@id"] = OrganizationSchemaRenderer.Id },
            ["hasOfferCatalog"] = new Dictionary<string, object?>
            {
                ["@type"] = "OfferCatalog",
                ["name"] = $"{valve.Name} Seals & Spare Parts",
                ["itemListElement"] = valve.SealTypes.Select(sealType => new Dictionary<string, object?>
                {
                    ["@type"] = "Offer",
                    ["itemOffered"] = new Dictionary<string, object?>
                    {
                        ["@type"] = "Product",
                        ["name"] = sealType,
                    },
                }).ToList(),
            },
        };

        var breadcrumbs = new Dictionary<string, object?>
        {
            ["@context"] = "https://schema.org",
            ["@type"] = "BreadcrumbList",
            ["itemListElement"] = new List<object>
            {
                new Dictionary<string, object?> { ["@type"] = "ListItem", ["position"] = 1, ["name"] = "Home", ["item"] = $"{SiteUrl}/" },
                new Dictionary<string, object?> { ["@type"] = "ListItem", ["position"] = 2, ["name"] = valve.Name, ["item"] = pageUrl },
            },
        };

        var schemas = new List<object> { service, breadcrumbs };

        if (valve.Faqs.Count > 0)
        {
            schemas.Add(new Dictionary<string, object?>
            {
                ["@context"] = "https://schema.org",
                ["@type"] = "FAQPage",
                ["mainEntity"] = valve.Faqs.Select(faq => new Dictionary<string, object?>
                {
                    ["@type"] = "Question",
                    ["name"] = faq.Question,
                    ["acceptedAnswer"] = new Dictionary<string, object?>
                    {
                        ["@type"] = "Answer",
                        ["text"] = faq.Answer,
                    },
                }).ToList(),
            });
        }

        return JsonSerializer.Serialize(schemas, Options);
    }
}
