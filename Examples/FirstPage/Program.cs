using StudioStock.Components;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
var app = builder.Build();
app.UseExceptionHandler("/error", createScopeForErrors: true);
app.UseStaticFiles();
app.UseAntiforgery();
app.MapGet("/error", () => Results.Problem("The request could not be completed. Check the server log."));
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.Run();
