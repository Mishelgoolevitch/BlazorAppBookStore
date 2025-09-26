using BlazorAppBookStore.Components;
using BlazorAppBookStore.Models;
using BlazorAppBookStore.Services;



var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddScoped<Cart>();
    // другие сервисы

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddRazorComponents();
builder.Services.AddScoped<IBookReviewService, BookReviewService>();
//builder.MapRazorComponents<App>.AddInteractiveServerRenderMode();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
   
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();
app.UseStaticFiles();
app.MapStaticAssets();
app.MapRazorComponents<App>();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.Run();
