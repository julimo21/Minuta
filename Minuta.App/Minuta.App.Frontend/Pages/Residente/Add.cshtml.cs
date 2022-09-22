using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class AddModel4 : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        [BindProperty]
        public Minuta.App.Dominio.Residente Residente{get;set;}
        public AddModel4(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public IActionResult OnGet(int residenteId)
        {
            Residente = new App.Dominio.Residente();

            if(Residente == null)
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
            Residente = repositorioResidente.AddResidente(Residente);            
            return Page();
        }
    }
}
