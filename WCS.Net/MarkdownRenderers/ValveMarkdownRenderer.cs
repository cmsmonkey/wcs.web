using System.Text;
using WCS.Net.Models;

namespace WCS.Net.MarkdownRenderers;

/// <summary>Renders a ValveViewModel as a leaner Markdown summary of its HTML page (Views/Valves/Show.cshtml).</summary>
public static class ValveMarkdownRenderer
{
    public static string Render(ValveViewModel valve)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"# {valve.Name}");
        sb.AppendLine();
        sb.AppendLine($"*{valve.Kicker}*");
        sb.AppendLine();

        foreach (var paragraph in valve.IntroParagraphs)
        {
            sb.AppendLine(paragraph);
            sb.AppendLine();
        }

        sb.AppendLine("## Photos");
        sb.AppendLine();
        foreach (var photo in valve.Photos)
        {
            sb.AppendLine($"- {photo.Caption ?? photo.Alt}");
        }
        sb.AppendLine();

        if (valve.Callout is not null)
        {
            sb.AppendLine($"## {valve.Callout.Title}");
            sb.AppendLine();
            sb.AppendLine(valve.Callout.Body);
            sb.AppendLine();
        }

        var others = ValveCatalog.AllExcept(valve.Slug).ToList();
        if (others.Count > 0)
        {
            sb.AppendLine("## Other Valve Types");
            sb.AppendLine();
            foreach (var other in others)
            {
                sb.AppendLine($"- [{other.Name}](/valves/{other.Slug}): {other.Teaser}");
            }
            sb.AppendLine();
        }

        sb.AppendLine("## Get a Quote");
        sb.AppendLine();
        sb.AppendLine("Send the final quote you've received for valve or actuator spares, and we'll tell you — in writing — how much lower we can go.");
        sb.AppendLine();
        sb.AppendLine("Call +47 950 06 101 · Email tb@wcryoservices.com · www.wcryoservices.com");

        return sb.ToString();
    }
}
