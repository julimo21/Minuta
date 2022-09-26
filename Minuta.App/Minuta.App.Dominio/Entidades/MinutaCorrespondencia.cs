using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     
    public class MinutaCorrespondencia : MinutaVigilancia
    {
        [Required(ErrorMessage = "Debe seleccionar el residente")]
        public Residente residente { get; set; }
        [Required(ErrorMessage = "Debe ingresar el tipo de correspondencia")]
        public string tipoCorrespondencia { get; set; }
        [Required(ErrorMessage = "Debe ingresar la persona que entrega")]
        public string personaEntrega { get; set; }
        [Required(ErrorMessage = "Debe ingresar la persona que recibe")]
        public string personaRecibe { get; set; }
        [Required(ErrorMessage = "Debe ingresar la persona que firmó el recibido")]
        public string firmaRecibido { get; set; }
        [Required(ErrorMessage = "Debe ingresar las observaciones")]
        public string observaciones { get; set; }
    }
}