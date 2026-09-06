using Microsoft.AspNetCore.Mvc;
using WCS.Net.Models;

namespace WCS.Net.Controllers;

public class ValvesController : Controller
{
    [Route("valves/{slug}")]
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
}
