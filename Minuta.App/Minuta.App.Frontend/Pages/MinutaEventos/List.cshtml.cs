using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel7 : PageModel
    {
        private readonly IRepositorioMinutaEventos repositorioMinutaEventos;
        public IEnumerable<Minuta.App.Dominio.MinutaEventos> MinutaEventos{get;set;}
        public ListModel7(IRepositorioMinutaEventos repositorioMinutaEventos)
        {
            this.repositorioMinutaEventos = repositorioMinutaEventos;
        }
        public void OnGet()
        {
            MinutaEventos = repositorioMinutaEventos.GetAllMinutaEventos();
        }
    }
}
