using System;
namespace Minuta.App.Dominio
{
     
    public class Residente : Usuario
    {
        public string numApartamentoRes { get; set; }
        public string numParqueaderoRes { get; set; }
        public string celularRes { get; set; }
        //public string usuario { get; set; }
        //public string contrasena { get; set; }
    }
}
