using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaVisitante : MinutaVigilancia
    {
        public Visitante visitante { get; set; }
        //public Persona visitante { get; set; }
        public DateTime fechaSalidaVis { get; set; }
        public DateTime horaSalidaVis { get; set; }
    }
}