using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel2 : PageModel
    {
       private readonly IRepositorioMinutaVisitante repositorioMinutaVisitante;
        [BindProperty]
        public Minuta.App.Dominio.MinutaVisitante MinutaVisitante{get;set;}
        [BindProperty]
        public string cedulaVisitante {get;set;}
        public string fecha;
        public string hora;
        public AddModel2(IRepositorioMinutaVisitante repositorioMinutaVisitante)
        {
            this.repositorioMinutaVisitante = repositorioMinutaVisitante;
        }
        public IActionResult OnGet(int minutaVisitanteId)
        {
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaVisitante = new App.Dominio.MinutaVisitante();
            if(MinutaVisitante == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaVisitante = repositorioMinutaVisitante.AddMinutaVisitante(MinutaVisitante);            
            return Page();
        }
    }
}
