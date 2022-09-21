using System;
using System.ComponentModel.DataAnnotations;
namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int id { get; set; }
        //[Required(ErrorMessage = "Debe ingresar el nombre")]
        public string nombre { get; set; }
        //[Required(ErrorMessage = "Debe ingresar los apellidos")]
        public string apellidos { get; set; }
        //[Required(ErrorMessage = "Debe ingresar la cédula")]
        public string cedula { get; set; }
        //public TipoUsuario tipoUsuario { set; get; }
        //public string numApartamento { get; set; }

    }
}
