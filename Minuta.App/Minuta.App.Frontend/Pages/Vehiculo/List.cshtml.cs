using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public IEnumerable<Minuta.App.Dominio.Vehiculo> Vehiculos{get;set;}
        public ListModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public void OnGet()
        {
            Vehiculos = repositorioVehiculo.GetAllVehiculo();
        }
    }
}
