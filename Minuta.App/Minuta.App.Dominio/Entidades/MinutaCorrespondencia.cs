using System;
namespace Minuta.App.Dominio
{
     
    public class MinutaCorrespondencia : MinutaVigilancia
    {
        public Residente residente { get; set; }
        public string tipoCorrespondencia { get; set; }
        public string personaEntrega { get; set; }
        public string personaRecibe { get; set; }
        public string firmaRecibido { get; set; }
        public string observaciones { get; set; }
    }
}