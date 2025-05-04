using Microsoft.EntityFrameworkCore;
using watchlistScreener.Data;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();
var connectionString = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTION");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new Exception("AZURE_SQL_CONNECTION environment variable is not set.");
}



builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
