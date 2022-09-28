using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel7 : PageModel
    {
        private readonly IRepositorioMinutaEventos repositorioMinutaEventos;
        [BindProperty]
        public Minuta.App.Dominio.MinutaEventos MinutaEventos{get;set;}
        public string fecha;
        public string hora;
        public EditModel7(IRepositorioMinutaEventos repositorioMinutaEventos)
        {
            this.repositorioMinutaEventos = repositorioMinutaEventos;
        }
        public IActionResult OnGet(int minutaEventosId)
        {
            //fecha = DateTime.Now.ToString("yyyy-MM-dd");
            //hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaEventos = repositorioMinutaEventos.GetMinutaEventos(minutaEventosId);
            if(MinutaEventos == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            //fecha = DateTime.Now.ToString("yyyy-MM-dd");
            //hora = DateTime.Now.ToString("hh:mm:ss tt");
            MinutaEventos = repositorioMinutaEventos.UpdateMinutaEventos(MinutaEventos);            
            return Page();
        }
    }
}
