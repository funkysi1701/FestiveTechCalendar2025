using FestiveTechCalendar2025.Components;
using Microsoft.SemanticKernel;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var key = builder.Configuration.GetValue<string>("OpenAI:Key");
var model = builder.Configuration.GetValue<string>("OpenAI:Model");
if (!string.IsNullOrEmpty(key))
{
    builder.Services.AddOpenAIChatCompletion(
        modelId: model ?? throw new ApplicationException("Missing OpenAI Config"),
        apiKey: key
    );
}
builder.Services.AddKernel();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
