using Economicus.Wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RoyalCode.Yasamen.Commons.Modules;
using RoyalCode.Yasamen.Forms.Modules;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// microsoft extensions
builder.Services.AddOptions();
//builder.Services.AddLocalization();

// yasamen services
builder.Services.AddDataServices();
builder.Services.AddYasamenLocalization();

// yasamen js modules
builder.Services.AddScoped<CommonsJsModule>();
builder.Services.AddScoped<ScrollJsModule>();
builder.Services.AddScoped<ToggleJsModule>();
builder.Services.AddScoped<CssStyleJsModule>();
builder.Services.AddScoped<FormsJsModule>();

await builder.Build().RunAsync();
