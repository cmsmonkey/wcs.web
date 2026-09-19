using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WCS.Net.MarkdownRenderers;
using WCS.Net.Models;
using WCS.Net.SitemapRenderers;

namespace WCS.Net.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Route("index.md")]
    public IActionResult IndexMarkdown()
    {
        return Content(HomeMarkdownRenderer.Render(), "text/markdown; charset=utf-8");
    }

    [Route("llms.txt")]
    public IActionResult LlmsTxt()
    {
        return Content(LlmsTxtRenderer.Render(), "text/markdown; charset=utf-8");
    }

    [Route("sitemap.xml")]
    public IActionResult SitemapXml()
    {
        return Content(SitemapXmlRenderer.Render(), "application/xml; charset=utf-8");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
