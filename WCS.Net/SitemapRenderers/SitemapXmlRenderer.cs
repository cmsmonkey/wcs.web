using System.Xml.Linq;
using WCS.Net.Models;

namespace WCS.Net.SitemapRenderers;

/// <summary>Renders /sitemap.xml from the same page registry that backs /llms.txt, so it can't go stale
/// the way a hand-maintained static file does (the old wwwroot/sitemap.xml only listed the home page).</summary>
public static class SitemapXmlRenderer
{
    private const string SiteUrl = "https://www.wcryoservices.com";
    private static readonly XNamespace Ns = "http://www.sitemaps.org/schemas/sitemap/0.9";

    public static string Render()
    {
        var urlset = new XElement(Ns + "urlset",
            SitePageRegistry.All().Select(page =>
            {
                var path = page.Path == "/" ? "" : page.Path;
                return new XElement(Ns + "url",
                    new XElement(Ns + "loc", $"{SiteUrl}{path}"),
                    new XElement(Ns + "priority", path == "" ? "1.0" : "0.8"));
            }));

        var declaration = new XDeclaration("1.0", "utf-8", null);
        return declaration + Environment.NewLine + urlset;
    }
}
