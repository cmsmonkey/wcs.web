using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;
using WCS.Net.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#if DEBUG
builder.Services.AddSassCompiler();
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseContentSecurityPolicyReportOnly();
app.Use(async (context, next) =>
{
    context.Response.Headers["Referrer-Policy"] = "strict-origin-when-cross-origin";
    await next();
});

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapContentSecurityPolicyReports();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.UseStaticFiles(new StaticFileOptions
{
    ServeUnknownFileTypes = true,
    DefaultContentType = "application/json",
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.WebRootPath, ".well-known")),
    RequestPath = "/.well-known"
});

app.Run();
