using Microsoft.AspNetCore.Mvc;
using WCS.Net.MarkdownRenderers;
using WCS.Net.Models;

namespace WCS.Net.Controllers;

public class ValvesController : Controller
{
    [Route("valves/{slug:regex(^[[a-z0-9-]]+$)}")]
    public IActionResult Show(string slug)
    {
        var valve = ValveCatalog.FindBySlug(slug);
        if (valve is null)
        {
            return NotFound();
        }

        // Entries with a custom RoutePath (e.g. Danfoss at "/actuators") don't live under "/valves/"
        // any more, and this site avoids redirects — so the old path is simply gone.
        if (valve.RoutePath is not null)
        {
            return NotFound();
        }

        return RenderShow(valve);
    }

    // Entries with a custom RoutePath get their own top-level route here, one attribute per entry.
    [Route("actuators")]
    [Route("lng-fuel-gas-supply-systems")]
    public IActionResult ShowAtRoutePath()
    {
        var path = "/" + (Request.Path.Value ?? "").Trim('/');
        var valve = ValveCatalog.All.FirstOrDefault(v => v.RoutePath == path);
        return valve is null ? NotFound() : RenderShow(valve);
    }

    [Route("valves/{slug}.md")]
    public IActionResult ShowMarkdown(string slug)
    {
        var valve = ValveCatalog.FindBySlug(slug);
        if (valve is null)
        {
            return NotFound();
        }

        if (valve.RoutePath is not null)
        {
            return NotFound();
        }

        return RenderShowMarkdown(valve);
    }

    [Route("actuators.md")]
    [Route("lng-fuel-gas-supply-systems.md")]
    public IActionResult ShowAtRoutePathMarkdown()
    {
        var path = "/" + (Request.Path.Value ?? "").Trim('/');
        var valve = ValveCatalog.All.FirstOrDefault(v => $"{v.RoutePath}.md" == path);
        return valve is null ? NotFound() : RenderShowMarkdown(valve);
    }

    private IActionResult RenderShow(ValveViewModel valve)
    {
        ViewData["Title"] = valve.MetaTitle ?? $"{valve.Name} - World Cryo Services";
        ViewData["Description"] = valve.MetaDescription ?? $"World Cryo Services — service and spare parts for {valve.Name} cryogenic valves.";
        return View("Show", valve);
    }

    private IActionResult RenderShowMarkdown(ValveViewModel valve) =>
        Content(ValveMarkdownRenderer.Render(valve), "text/markdown; charset=utf-8");
}
