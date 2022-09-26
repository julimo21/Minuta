using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel6 : PageModel
    {
        private readonly IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia;
        private readonly IRepositorioResidente repositorioResidente;
        [BindProperty]
        public Minuta.App.Dominio.MinutaCorrespondencia MinutaCorrespondencia{get;set;}
        [BindProperty]
        public string cedulaResidente {get;set;}
        public string fecha;
        public string hora;
        public IEnumerable<Minuta.App.Dominio.Residente> Residentes;
        public EditModel6(IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia)
        {
            this.repositorioMinutaCorrespondencia = repositorioMinutaCorrespondencia;
            this.repositorioResidente = new RepositorioResidente();
        }
        public IActionResult OnGet(int minutaCorrespondenciaId)
        {
            //fecha = DateTime.Now.ToString("yyyy-MM-dd");
            //hora = DateTime.Now.ToString("hh:mm:ss tt");
            Residentes = repositorioResidente.GetAllResidente();
            MinutaCorrespondencia = repositorioMinutaCorrespondencia.GetMinutaCorrespondencia(minutaCorrespondenciaId);
            if(MinutaCorrespondencia == null)
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
            Residentes = repositorioResidente.GetAllResidente();
            MinutaCorrespondencia = repositorioMinutaCorrespondencia.UpdateMinutaCorrespondencia(MinutaCorrespondencia, cedulaResidente);            
            return Page();
        }
    }
}
