using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel5 : PageModel
    {
        private readonly IRepositorioAdministrador repositorioAdministrador;
        [BindProperty]
        public Minuta.App.Dominio.Administrador Administrador{get;set;}
        public AddModel5(IRepositorioAdministrador repositorioAdministrador)
        {
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public IActionResult OnGet(int administradorId)
        {
            Administrador = new App.Dominio.Administrador();

            if(Administrador == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Administrador = repositorioAdministrador.AddAdministrador(Administrador);            
            return Page();
        }
    }
}
