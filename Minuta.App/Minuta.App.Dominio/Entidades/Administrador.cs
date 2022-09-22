using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Administrador : Persona
    {
        [Required(ErrorMessage = "Debe ingresar el número de celular")]
        public string celularAdm { get; set; }
        [Required(ErrorMessage = "Debe ingresar el correo")]
        public string correoAdm { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }

    }
}
