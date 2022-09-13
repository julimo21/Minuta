using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel1 : PageModel
    {
        private readonly IRepositorioVisitante repositorioVisitante;
        [BindProperty]
        public Minuta.App.Dominio.Visitante Visitante{get;set;}
        public EditModel1(IRepositorioVisitante repositorioVisitante)
        {
            this.repositorioVisitante = repositorioVisitante;
        }
        public IActionResult OnGet(int visitanteId)
        {
            Visitante = repositorioVisitante.GetVisitante(visitanteId);
            if(Visitante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Visitante = repositorioVisitante.UpdateVisitante(Visitante);            
            return Page();
        }
    }
}
