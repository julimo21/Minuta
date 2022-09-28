using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel7 : PageModel
    {
        private readonly IRepositorioMinutaEventos repositorioMinutaEventos;
        [BindProperty]
        public Minuta.App.Dominio.MinutaEventos MinutaEventos{get;set;}
        public string fecha;
        public string hora;
        public AddModel7(IRepositorioMinutaEventos repositorioMinutaEventos)
        {
            this.repositorioMinutaEventos = repositorioMinutaEventos;
        }
        public IActionResult OnGet(int minutaEventosId)
        {
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaEventos = new App.Dominio.MinutaEventos();
            if(MinutaEventos == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            /*if(!ModelState.IsValid)
            {
                return Page();
            }*/
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaEventos = repositorioMinutaEventos.AddMinutaEventos(MinutaEventos);            
            return Page();
        }
    }
}
