using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel7 : PageModel
    {
        private readonly IRepositorioMinutaEventos repositorioMinutaEventos;
        [BindProperty]
        public Minuta.App.Dominio.MinutaEventos MinutaEventos{get;set;}
        public DeleteModel7(IRepositorioMinutaEventos repositorioMinutaEventos)
        {
            this.repositorioMinutaEventos = repositorioMinutaEventos;
        }
        public IActionResult OnGet(int minutaEventosId)
        {
            MinutaEventos = repositorioMinutaEventos.GetMinutaEventos(minutaEventosId);
            if(MinutaEventos == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost(int minutaEventosId)
        {
            //MinutaEventos = repositorioMinutaEventos.GetMinutaEventos(minutaEventosId);
            repositorioMinutaEventos.DeleteMinutaEventos(minutaEventosId);            
            return RedirectToPage("./List");
        }
    }
}
