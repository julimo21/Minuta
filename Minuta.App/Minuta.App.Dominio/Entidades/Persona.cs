namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        //public TipoUsuario tipoUsuario { set; get; }
        //public string numApartamento { get; set; }

    }
}
