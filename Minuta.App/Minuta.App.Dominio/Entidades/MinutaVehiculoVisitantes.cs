using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaVehiculoVisitantes : MinutaVigilancia
    {
        public Visitante visitante { get; set; }
        //public Persona visitante { get; set; }
        public Vehiculo vehiculoVis { get; set; }
        public DateTime fechaSalidaVehVis { get; set; }
        public DateTime horaSalidaVehVis { get; set; }
        public string numParqueaderoVis { get; set; }
    }
}