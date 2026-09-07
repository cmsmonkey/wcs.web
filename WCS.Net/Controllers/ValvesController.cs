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

        ViewData["Title"] = $"{valve.Name} - World Cryo Services";
        ViewData["Description"] = $"World Cryo Services — service and spare parts for {valve.Name} cryogenic valves.";
        return View(valve);
    }

    [Route("valves/{slug}.md")]
    public IActionResult ShowMarkdown(string slug)
    {
        var valve = ValveCatalog.FindBySlug(slug);
        if (valve is null)
        {
            return NotFound();
        }

        return Content(ValveMarkdownRenderer.Render(valve), "text/markdown");
    }
}
