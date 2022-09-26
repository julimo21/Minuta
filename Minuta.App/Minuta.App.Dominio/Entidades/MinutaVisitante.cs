using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class MinutaVisitante : MinutaVigilancia
    {
        [Required(ErrorMessage = "Debe seleccionar el visitante")]
        public Visitante visitante { get; set; }
        //public Persona visitante { get; set; }
        [Required(ErrorMessage = "Debe ingresar la fecha de salida (formato aaaa-mm-dd)")]
        public string fechaSalidaVis { get; set; }
        [Required(ErrorMessage = "Debe ingresar la hora de salida (formato hh:mm:ss)")]
        public string horaSalidaVis { get; set; }
    }
}