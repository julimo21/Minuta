using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel4 : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        public IEnumerable<Minuta.App.Dominio.Residente> Residentes{get;set;}
        public ListModel4(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public void OnGet()
        {
            Residentes = repositorioResidente.GetAllResidente();
        }
    }
}
