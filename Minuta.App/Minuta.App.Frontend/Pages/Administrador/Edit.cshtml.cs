using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel5 : PageModel
    {
        private readonly IRepositorioAdministrador repositorioAdministrador;
        [BindProperty]
        public Minuta.App.Dominio.Administrador Administrador{get;set;}
        public EditModel5(IRepositorioAdministrador repositorioAdministrador)
        {
            this.repositorioAdministrador = repositorioAdministrador;
        }
        public IActionResult OnGet(int administradorId)
        {
            Administrador = repositorioAdministrador.GetAdministrador(administradorId);
            if(Administrador == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Administrador = repositorioAdministrador.UpdateAdministrador(Administrador);            
            return Page();
        }
    }
}
