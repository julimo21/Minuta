using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaVehiculoResidentes : MinutaVigilancia
    {
        public Residente residente { get; set; }
        public Vehiculo vehiculoRes { get; set; }
        public string observaciones { get; set; }
    }
}