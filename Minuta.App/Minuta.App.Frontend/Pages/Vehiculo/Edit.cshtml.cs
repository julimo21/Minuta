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
        public IActionResult OnGet(int? vehiculoId)
        {
            if (vehiculoId.HasValue)
            {
                Vehiculo = repositorioVehiculo.GetVehiculo(vehiculoId.Value);
            }
            else
            {
                Vehiculo = new Vehiculo();
            }
            if(Vehiculo == null)
            {
                return RedirectToPage("./NotFound");
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
            if(Vehiculo.id > 0)
            {
                Vehiculo = repositorioVehiculo.UpdateVehiculo(Vehiculo);  
            }
            else
            {
                repositorioVehiculo.AddVehiculo(Vehiculo);        
            }         
            return Page();
        }
    }
}
