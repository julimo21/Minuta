using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel1 : PageModel
    {
        private readonly IRepositorioVisitante repositorioVisitante;
        [BindProperty]
        public Minuta.App.Dominio.Visitante Visitante{get;set;}
        public AddModel1(IRepositorioVisitante repositorioVisitante)
        {
            this.repositorioVisitante = repositorioVisitante;
        }
        public IActionResult OnGet(int visitanteId)
        {
            Visitante = new App.Dominio.Visitante();

            if(Visitante == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Visitante = repositorioVisitante.AddVisitante(Visitante);            
            return Page();
        }
    }
}
