using Microsoft.EntityFrameworkCore;
using AurumLab.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AurumLab.Data.AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

//* Acrescentar antes do var app = builder.Build();
// Ativa o serviço de sessão na aplicação (permite salvar dados temporários como login)
builder.Services.AddSession();

var app = builder.Build();

//* Acrescentar depois do var app = builder.Build();
// Habilita o uso da sessão nas rotas (necessário para acessar Session dentro do MVC)
app.UseSession();

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
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();