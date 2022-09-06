using System;
namespace Minuta.App.Dominio
{
     
    public class Usuario : Persona
    {    
        public string idUsuario { get; set; }
        public string contrasena { get; set; }
        public RolUsuario tipo { get; set; }
    }
}