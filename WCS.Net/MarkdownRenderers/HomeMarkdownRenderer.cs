using System.Text;
using WCS.Net.Models;

namespace WCS.Net.MarkdownRenderers;

/// <summary>
/// Renders a leaner Markdown summary of the Home page. Unlike the valve pages, Home's content
/// isn't model-driven yet (it's hand-written across Views/Home/Sections/*.cshtml), so this is a
/// hand-written distillation of that same copy rather than a render of a shared model — keep the
/// two in sync manually if the Home page's copy changes.
/// </summary>
public static class HomeMarkdownRenderer
{
    public static string Render()
    {
        var sb = new StringBuilder();

        sb.AppendLine("# World Cryo Services");
        sb.AppendLine();
        sb.AppendLine("*Independent Cryogenic Valve Service*");
        sb.AppendLine();
        sb.AppendLine("## Better. Faster. Cheaper.");
        sb.AppendLine();
        sb.AppendLine("Service and spare parts for LNG cryogenic butterfly valves and actuators — every major brand, one independent provider.");
        sb.AppendLine();
        sb.AppendLine("- 16+ years, founder's experience");
        sb.AppendLine("- 400+ dockings & jobs attended");
        sb.AppendLine("- 25%+ guaranteed savings vs. OEM");
        sb.AppendLine("- 24/7 global field service, 365 days");
        sb.AppendLine();

        sb.AppendLine("## The WCS Price Guarantee");
        sb.AppendLine();
        sb.AppendLine("Send us the OEM's final quote — Klinger Westad or KSB Amri — and we guarantee to come in at least 25% lower on WCS-manufactured alternatives, same quality and full compatibility. Applies to the LPG seal line too.");
        sb.AppendLine();

        sb.AppendLine("## What We Offer");
        sb.AppendLine();
        sb.AppendLine("- Global field service, 24/7/365");
        sb.AppendLine("- Valve & actuator overhaul, one provider for both");
        sb.AppendLine("- Work on discontinued models, including parts the OEM no longer produces");
        sb.AppendLine("- Tailored wear & tear parts, reverse-engineered and manufactured to order");
        sb.AppendLine();

        sb.AppendLine("## Why Choose WCS");
        sb.AppendLine();
        sb.AppendLine("- 16+ yrs — one of the deepest track records in the industry");
        sb.AppendLine("- 400+ dockings and jobs attended worldwide");
        sb.AppendLine("- 25–40% typical savings against OEM pricing");
        sb.AppendLine("- Machines its own metal seals in Norway — the only supplier for some discontinued valve types");
        sb.AppendLine("- Reuses components OEMs throw away, lowering cost and environmental impact");
        sb.AppendLine("- Small, flexible, and reachable 24/7, independent of any single supplier");
        sb.AppendLine();

        sb.AppendLine("## Parts We Manufacture & Supply");
        sb.AppendLine();
        foreach (var valve in ValveCatalog.All)
        {
            sb.AppendLine($"- [{valve.Name}](/valves/{valve.Slug}): {valve.Teaser}");
        }
        sb.AppendLine();

        sb.AppendLine("## The Team");
        sb.AppendLine();
        sb.AppendLine("Thor Bjerke founded WCS after nine years at Klinger Westad — from one person in January 2018 to four today: Thor Bjerke (General Manager/CEO), Aleksander Bjerke (Service Engineer), Kristian L. Selvik (Service Engineer Trainee), and Kjersti Bjerke (Coordinator).");
        sb.AppendLine();

        sb.AppendLine("## Get In Touch");
        sb.AppendLine();
        sb.AppendLine("Send the final quote you've received for valve or actuator spares, and we'll tell you — in writing — how much lower we can go.");
        sb.AppendLine();
        sb.AppendLine("Call +47 950 06 101 · Email tb@wcryoservices.com · www.wcryoservices.com");

        return sb.ToString();
    }
}
