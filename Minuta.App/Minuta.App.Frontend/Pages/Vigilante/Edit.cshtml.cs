using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel3 : PageModel
    {
        private readonly IRepositorioVigilante repositorioVigilante;
        [BindProperty]
        public Minuta.App.Dominio.Vigilante Vigilante{get;set;}
        public EditModel3(IRepositorioVigilante repositorioVigilante)
        {
            this.repositorioVigilante = repositorioVigilante;
        }
        public IActionResult OnGet(int vigilanteId)
        {
            Vigilante = repositorioVigilante.GetVigilante(vigilanteId);
            if(Vigilante == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Vigilante = repositorioVigilante.UpdateVigilante(Vigilante);            
            return Page();
        }
    }
}
