using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Residente : Persona
    {
        public string numApartamentoRes { get; set; }
        public string numParqueaderoRes { get; set; }
        public string celularRes { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }
    }
}
