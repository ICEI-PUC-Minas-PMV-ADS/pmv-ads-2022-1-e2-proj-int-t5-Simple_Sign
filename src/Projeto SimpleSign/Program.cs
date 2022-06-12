
using FluentAssertions.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleSign.Data;

using SimpleSign.Helper;
using SimpleSign.Repositorio;

using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
var movieApiKey = builder.Configuration["ServiceApiKey"];




// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkSqlServer()
  
    
.AddDbContext<BancoContent>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

 
builder.Services.AddDbContext<ArquivoContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Database")));



builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<ISessao, Sessao>();



builder.Services.AddMvc();

builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
       o.TokenLifespan = TimeSpan.FromHours(3));



builder.Services.AddSession(o =>
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Ir}/{id?}");

app.Run();
