using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel2 : PageModel
    {
        private readonly IRepositorioMinutaVisitante repositorioMinutaVisitante;
        [BindProperty]
        public Minuta.App.Dominio.MinutaVisitante MinutaVisitante{get;set;}
        public DeleteModel2(IRepositorioMinutaVisitante repositorioMinutaVisitante)
        {
            this.repositorioMinutaVisitante = repositorioMinutaVisitante;
        }
        public IActionResult OnGet(int minutaVisitanteId)
        {
            MinutaVisitante = repositorioMinutaVisitante.GetMinutaVisitante(minutaVisitanteId);
            if(MinutaVisitante == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost(int minutaVisitanteId)
        {
            //MinutaVisitante = repositorioMinutaVisitante.GetMinutaVisitante(minutaVisitanteId);
            repositorioMinutaVisitante.DeleteMinutaVisitante(minutaVisitanteId);            
            return Page();
        }
    }
}
