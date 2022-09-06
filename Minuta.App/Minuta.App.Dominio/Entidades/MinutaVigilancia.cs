namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class MinutaVigilancia
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string asunto { get; set; }       
    }
}
