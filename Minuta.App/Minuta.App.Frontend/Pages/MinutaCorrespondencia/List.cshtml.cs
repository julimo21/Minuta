using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel6 : PageModel
    {
        private readonly IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia;
        public IEnumerable<Minuta.App.Dominio.MinutaCorrespondencia> MinutaCorrespondencias{get;set;}
        public ListModel6(IRepositorioMinutaCorrespondencia repositorioMinutaCorrespondencia)
        {
            this.repositorioMinutaCorrespondencia = repositorioMinutaCorrespondencia;
        }
        public void OnGet()
        {
            MinutaCorrespondencias = repositorioMinutaCorrespondencia.GetAllMinutaCorrespondencia();
        }
    }
}
