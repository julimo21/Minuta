using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel3 : PageModel
    {
        private readonly IRepositorioVigilante repositorioVigilante;
        [BindProperty]
        public Minuta.App.Dominio.Vigilante Vigilante{get;set;}
        public AddModel3(IRepositorioVigilante repositorioVigilante)
        {
            this.repositorioVigilante = repositorioVigilante;
        }
        public IActionResult OnGet(int vigilanteId)
        {
            Vigilante = new App.Dominio.Vigilante();

            if(Vigilante == null)
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
            Vigilante = repositorioVigilante.AddVigilante(Vigilante);            
            return Page();
        }
    }
}
