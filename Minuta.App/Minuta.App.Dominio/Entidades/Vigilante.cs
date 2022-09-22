using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Vigilante : Persona
    {
        [Required(ErrorMessage = "Debe ingresar la empresa")]
        public string empresa { get; set; }
        [Required(ErrorMessage = "Debe ingresar el turno")]
        public string turno { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }
    }
}
