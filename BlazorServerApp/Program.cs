using BlazorServerApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddViewModels();

var app = builder.Build();

app.UseRouting();

app.UseStaticFiles();

app.MapFallbackToPage("/Host");
app.MapBlazorHub();

app.Run();
