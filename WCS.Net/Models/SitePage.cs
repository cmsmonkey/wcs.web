namespace WCS.Net.Models;

/// <summary>One entry in the site's page registry — backs /llms.txt (and, later, an XML sitemap).</summary>
public record SitePage(string Title, string Path, string MarkdownPath, string Description);

public static class SitePageRegistry
{
    public static IEnumerable<SitePage> All()
    {
        yield return new SitePage(
            "Home",
            "/",
            "/index.md",
            "World Cryo Services — independent cryogenic butterfly valve service and spare parts for LNG carriers.");

        foreach (var valve in ValveCatalog.All)
        {
            yield return new SitePage(
                valve.Name,
                $"/valves/{valve.Slug}",
                $"/valves/{valve.Slug}.md",
                valve.Teaser);
        }
    }
}
