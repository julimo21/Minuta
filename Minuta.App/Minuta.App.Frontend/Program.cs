using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddSingleton<IRepositorioAdministrador, RepositorioAdministrador>();
//builder.Services.AddSingleton<IRepositorioVigilante, RepositorioVigilante>();
//builder.Services.AddSingleton<IRepositorioResidente, RepositorioResidente>();
//builder.Services.AddSingleton<IRepositorioVisitante, RepositorioVisitante>();
//builder.Services.AddSingleton<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddSingleton<IRepositorioPrueba, RepositorioPrueba>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
