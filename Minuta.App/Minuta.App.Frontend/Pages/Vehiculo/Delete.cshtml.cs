using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        [BindProperty]
        public Minuta.App.Dominio.Vehiculo Vehiculo{get;set;}
        public DeleteModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public IActionResult OnGet(int vehiculoId)
        {
            Vehiculo = repositorioVehiculo.GetVehiculo(vehiculoId);
            if(Vehiculo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            repositorioVehiculo.DeleteVehiculo(Vehiculo.id);            
            return Page();
        }
    }
}
