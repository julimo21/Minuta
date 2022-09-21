using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaVisitante : MinutaVigilancia
    {
        public Visitante visitante { get; set; }
        //public Persona visitante { get; set; }
        public string fechaSalidaVis { get; set; }
        public string horaSalidaVis { get; set; }
    }
}