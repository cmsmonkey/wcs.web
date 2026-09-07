using System.Text;
using WCS.Net.Models;

namespace WCS.Net.MarkdownRenderers;

/// <summary>Renders /llms.txt — the site-wide index per the llms.txt convention (https://llmstxt.org/).</summary>
public static class LlmsTxtRenderer
{
    public static string Render()
    {
        var sb = new StringBuilder();

        sb.AppendLine("# World Cryo Services");
        sb.AppendLine();
        sb.AppendLine("> Independent cryogenic butterfly valve service and spare parts for LNG carriers.");
        sb.AppendLine();
        sb.AppendLine("## Pages");
        sb.AppendLine();
        foreach (var page in SitePageRegistry.All())
        {
            sb.AppendLine($"- [{page.Title}]({page.MarkdownPath}): {page.Description}");
        }

        return sb.ToString();
    }
}
