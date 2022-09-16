using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel1 : PageModel
    {
        private readonly IRepositorioVisitante repositorioVisitante;
        [BindProperty]
        public Minuta.App.Dominio.Visitante Visitante{get;set;}
        public DeleteModel1(IRepositorioVisitante repositorioVisitante)
        {
            this.repositorioVisitante = repositorioVisitante;
        }
        public IActionResult OnGet(int visitanteId)
        {
            Visitante = repositorioVisitante.GetVisitante(visitanteId);
            if(Visitante == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost(int visitanteId)
        {
            repositorioVisitante.DeleteVisitante(visitanteId);            
            return Page();
        }
    }
}
