using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;
using Minuta.App.Persistencia.AppRepositorios;

namespace Minuta.App.Frontend.Pages
{
    public class EditModel4 : PageModel
    {
        private readonly IRepositorioResidente repositorioResidente;
        [BindProperty]
        public Minuta.App.Dominio.Residente Residente{get;set;}
        public EditModel4(IRepositorioResidente repositorioResidente)
        {
            this.repositorioResidente = repositorioResidente;
        }
        public IActionResult OnGet(int residenteId)
        {
            Residente = repositorioResidente.GetResidente(residenteId);
            if(Residente == null)
            {
                return RedirectToPage("./List");
            }
            else
            return Page();
        }
        public IActionResult OnPost()
        {
            Residente = repositorioResidente.UpdateResidente(Residente);            
            return Page();
        }
    }
}
