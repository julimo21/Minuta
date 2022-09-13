using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel1 : PageModel
    {
        private readonly IRepositorioVisitante repositorioVisitante;
        public IEnumerable<Minuta.App.Dominio.Visitante> Visitantes{get;set;}
        public ListModel1(IRepositorioVisitante repositorioVisitante)
        {
            this.repositorioVisitante = repositorioVisitante;
        }
        public void OnGet()
        {
            Visitantes = repositorioVisitante.GetAllVisitante();
        }
    }
}
