namespace WCS.Net.Security;

public static class ContentSecurityPolicy
{
    public const string ReportPath = "/csp-report";
    const int MaxReportLength = 8192;

    public static string Build(string reportUrl) => string.Join("; ",
        "default-src 'self'",
        "script-src 'self' https://consent.cookiebot.com https://consentcdn.cookiebot.com https://www.googletagmanager.com",
        "style-src 'self' 'unsafe-inline' https://fonts.googleapis.com",
        "font-src 'self' https://fonts.gstatic.com",
        "img-src 'self' data: https://imgsrc.cookiebot.com https://*.google-analytics.com https://*.googletagmanager.com",
        "connect-src 'self' https://consent.cookiebot.com https://consentcdn.cookiebot.com https://*.google-analytics.com https://*.analytics.google.com https://*.googletagmanager.com",
        "frame-src https://consentcdn.cookiebot.com",
        "object-src 'none'",
        "base-uri 'self'",
        "form-action 'self'",
        "frame-ancestors 'none'",
        $"report-uri {reportUrl}",
        "report-to csp");

    public static IApplicationBuilder UseContentSecurityPolicyReportOnly(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            var reportUrl = $"{context.Request.Scheme}://{context.Request.Host}{ReportPath}";
            context.Response.Headers["Content-Security-Policy-Report-Only"] = Build(reportUrl);
            context.Response.Headers["Reporting-Endpoints"] = $"csp=\"{reportUrl}\"";
            await next();
        });

    public static IEndpointRouteBuilder MapContentSecurityPolicyReports(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapPost(ReportPath, async (HttpRequest request, ILoggerFactory loggerFactory) =>
        {
            var buffer = new char[MaxReportLength];
            using var reader = new StreamReader(request.Body);
            var length = await reader.ReadBlockAsync(buffer);
            loggerFactory.CreateLogger(nameof(ContentSecurityPolicy))
                .LogWarning("CSP violation: {Report}", new string(buffer, 0, length));
            return Results.NoContent();
        });
        return endpoints;
    }
}
