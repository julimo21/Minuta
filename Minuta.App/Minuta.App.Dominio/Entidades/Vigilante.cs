using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Vigilante : Persona
    {
        public string empresa { get; set; }
        public string turno { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }
    }
}
