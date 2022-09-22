using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel3 : PageModel
    {
        private readonly IRepositorioVigilante repositorioVigilante;
        [BindProperty]
        public Minuta.App.Dominio.Vigilante Vigilante{get;set;}
        public DeleteModel3(IRepositorioVigilante repositorioVigilante)
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
        public IActionResult OnPost(int vigilanteId)
        {
            repositorioVigilante.DeleteVigilante(vigilanteId);            
            return Page();
        }
    }
}
