namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela un vehiculo en general en el sistema 
     /// </summary>   
    public class Vehiculo
    {
        // Identificador único de cada vehiculo
        public int id { get; set; }
        public string placa { get; set; }
        public TipoVehiculo tipoVehiculo { set; get; }

    }
}
