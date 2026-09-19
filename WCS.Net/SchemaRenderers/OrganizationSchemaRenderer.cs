using System.Text.Json;

namespace WCS.Net.SchemaRenderers;

/// <summary>Renders the site-wide Organization JSON-LD block. Page-level schema (see ValveSchemaRenderer)
/// links back to it by @id rather than repeating the org details on every page.</summary>
public static class OrganizationSchemaRenderer
{
    public const string Id = "https://www.wcryoservices.com/#organization";

    private static readonly JsonSerializerOptions Options = new() { WriteIndented = false };

    public static string Render()
    {
        var schema = new Dictionary<string, object?>
        {
            ["@context"] = "https://schema.org",
            ["@type"] = "Organization",
            ["@id"] = Id,
            ["name"] = "World Cryo Services AS",
            ["alternateName"] = "WCS",
            ["url"] = "https://www.wcryoservices.com",
            ["logo"] = "https://www.wcryoservices.com/images/logo.png",
            ["image"] = "https://www.wcryoservices.com/images/wcryoservices-logo-og.jpg",
            ["telephone"] = "+47 950 06 101",
            ["email"] = "tb@wcryoservices.com",
            ["address"] = new Dictionary<string, object?>
            {
                ["@type"] = "PostalAddress",
                ["streetAddress"] = "Strandveien 28",
                ["postalCode"] = "3530",
                ["addressLocality"] = "Røyse",
                ["addressCountry"] = "NO",
            },
        };

        return JsonSerializer.Serialize(schema, Options);
    }
}
