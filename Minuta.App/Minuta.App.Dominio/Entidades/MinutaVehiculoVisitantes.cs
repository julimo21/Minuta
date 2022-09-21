using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaVehiculoVisitantes : MinutaVigilancia
    {
        public Visitante visitante { get; set; }
        //public Persona visitante { get; set; }
        public Vehiculo vehiculoVis { get; set; }
        public string fechaSalidaVehVis { get; set; }
        public string horaSalidaVehVis { get; set; }
        public string numParqueaderoVis { get; set; }
    }
}