using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class ListModel5 : PageModel
    {
        private readonly IRepositorioAdministrador repositorioAdministrador;
        public IEnumerable<Minuta.App.Dominio.Administrador> Administradores{get;set;}
        public ListModel5(IRepositorioAdministrador repositorioAdministrador)
        {
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public void OnGet()
        {
            Administradores = repositorioAdministrador.GetAllAdministrador();
        }
    }
}
