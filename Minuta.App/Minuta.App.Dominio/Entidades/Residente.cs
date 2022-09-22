using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class Residente : Persona
    {
        [Required(ErrorMessage = "Debe ingresar el número del apartamento")]
        public string numApartamentoRes { get; set; }
        [Required(ErrorMessage = "Debe ingresar el número del parqueadero asignado")]
        public string numParqueaderoRes { get; set; }
        [Required(ErrorMessage = "Debe ingresar el número de celular")]
        public string celularRes { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }
    }
}
