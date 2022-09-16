using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        [BindProperty]
        public Minuta.App.Dominio.Vehiculo Vehiculo{get;set;}
        public AddModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public IActionResult OnGet(int vehiculoId)
        {
            Vehiculo = new App.Dominio.Vehiculo();

            if(Vehiculo == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Vehiculo = repositorioVehiculo.AddVehiculo(Vehiculo);            
            return Page();
        }
    }
}
