using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Frontend.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("IdentityDataContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityDataContextConnection' not found.");

builder.Services.AddDbContext<IdentityDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentityDataContext>();

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IRepositorioAdministrador, RepositorioAdministrador>();
builder.Services.AddSingleton<IRepositorioVigilante, RepositorioVigilante>();
builder.Services.AddSingleton<IRepositorioResidente, RepositorioResidente>();
builder.Services.AddSingleton<IRepositorioVisitante, RepositorioVisitante>();
builder.Services.AddSingleton<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddSingleton<IRepositorioMinutaCorrespondencia, RepositorioMinutaCorrespondencia>();
builder.Services.AddSingleton<IRepositorioMinutaEventos, RepositorioMinutaEventos>();
builder.Services.AddSingleton<IRepositorioMinutaVehiculoResidentes, RepositorioMinutaVehiculoResidentes>();
builder.Services.AddSingleton<IRepositorioMinutaVehiculoVisitantes, RepositorioMinutaVehiculoVisitantes>();
builder.Services.AddSingleton<IRepositorioMinutaVisitante, RepositorioMinutaVisitante>();
//builder.Services.AddSingleton<IRepositorioPrueba, RepositorioPrueba>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
