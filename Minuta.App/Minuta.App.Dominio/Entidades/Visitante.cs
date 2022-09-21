using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio

{
     
    public class Visitante : Persona
    {
        [Required(ErrorMessage = "Debe ingresar el número del apartamento")]
        public string numApartamentoVis { get; set; }
    }
}