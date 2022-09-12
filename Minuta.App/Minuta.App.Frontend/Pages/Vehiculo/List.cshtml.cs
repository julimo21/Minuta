using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPrueba repositorioPrueba;
        public IEnumerable<Minuta.App.Dominio.Vehiculo> Vehiculos{get;set;}
        public ListModel(IRepositorioPrueba repositorioPrueba)
        {
            this.repositorioPrueba = repositorioPrueba;
        }
        public void OnGet()
        {
            Vehiculos = repositorioPrueba.GetAll();
        }
    }
}
