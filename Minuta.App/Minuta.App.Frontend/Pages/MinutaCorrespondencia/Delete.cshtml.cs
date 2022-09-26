using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class DeleteModel6 : PageModel
    {
        private readonly IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia;
        [BindProperty]
        public Minuta.App.Dominio.MinutaCorrespondencia MinutaCorrespondencia{get;set;}
        public DeleteModel6(IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia)
        {
            this.repositorioMinutaCorrespondencia = repositorioMinutaCorrespondencia;
        }
        public IActionResult OnGet(int minutaCorrespondenciaId)
        {
            MinutaCorrespondencia = repositorioMinutaCorrespondencia.GetMinutaCorrespondencia(minutaCorrespondenciaId);
            if(MinutaCorrespondencia == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost(int minutaCorrespondenciaId)
        {
            //MinutaCorrespondencia = repositorioMinutaCorrespondencia.GetMinutaCorrespondencia(minutaCorrespondenciaId);
            repositorioMinutaCorrespondencia.DeleteMinutaCorrespondencia(minutaCorrespondenciaId);            
            return RedirectToPage("./List");
        }
    }
}
