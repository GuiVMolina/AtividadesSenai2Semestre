using Atividade_13._11___Sistema_Personagens_MVC.Data;
using Microsoft.EntityFrameworkCore;

namespace Atividade_13._11___Sistema_Personagens_MVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("ConexaoPadrao"),
                sqlOptions => sqlOptions.EnableRetryOnFailure()
            )
        );

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Personagem}/{action=Index}/{id?}")
            .WithStaticAssets();

        app.Run();
    }
}