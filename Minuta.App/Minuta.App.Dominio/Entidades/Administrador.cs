using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Administrador : Persona
    {
        public string celularAdm { get; set; }
        public string correoAdm { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }

    }
}
