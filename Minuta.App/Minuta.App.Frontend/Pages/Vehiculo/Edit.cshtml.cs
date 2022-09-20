using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        [BindProperty]
        public Minuta.App.Dominio.Vehiculo Vehiculo{get;set;}
        public EditModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public IActionResult OnGet(int vehiculoId)
        {
            Vehiculo = repositorioVehiculo.GetVehiculo(vehiculoId);
            if(Vehiculo == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Vehiculo = repositorioVehiculo.UpdateVehiculo(Vehiculo);            
            return Page();
        }
    }
}
