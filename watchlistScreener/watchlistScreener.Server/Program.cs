
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using watchlistScreener.Server.Data;

namespace watchlistScreener.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            DotNetEnv.Env.Load();
            var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION") ?? throw new InvalidOperationException();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddAuthorization();
            builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.MapIdentityApi<ApplicationUser>();


            app.MapPost("/logout", async (SignInManager<ApplicationUser> signInManager) =>
            {
                await signInManager.SignOutAsync();
                return Results.Ok();
            }).RequireAuthorization();

            app.MapPost("/pingauth", (ClaimsPrincipal user) =>
            {
                var email = user.FindFirstValue(ClaimTypes.Email);
                return Results.Json(new { Email = email });
            }).RequireAuthorization();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
