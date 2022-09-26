using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class MinutaVigilancia
    {
        public int id { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la fecha")]
        public string fecha { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la hora")]
        public string hora { get; set; }
        [Required(ErrorMessage = "Debe ingresar el asunto")]
        public string asunto { get; set; }       
    }
}
