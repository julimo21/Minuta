using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel2 : PageModel
    {
        private readonly IRepositorioMinutaVisitante repositorioMinutaVisitante;
        public IEnumerable<Minuta.App.Dominio.MinutaVisitante> MinutaVisitantes{get;set;}
        public ListModel2(IRepositorioMinutaVisitante repositorioMinutaVisitante)
        {
            this.repositorioMinutaVisitante = repositorioMinutaVisitante;
        }
        public void OnGet()
        {
            MinutaVisitantes = repositorioMinutaVisitante.GetAllMinutaVisitante();
        }
    }
}
