using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel3 : PageModel
    {
        private readonly IRepositorioVigilante repositorioVigilante;
        public IEnumerable<Minuta.App.Dominio.Vigilante> Vigilantes{get;set;}
        public ListModel3(IRepositorioVigilante repositorioVigilante)
        {
            this.repositorioVigilante = repositorioVigilante;
        }
        public void OnGet()
        {
            Vigilantes = repositorioVigilante.GetAllVigilante();
        }
    }
}
