using System;
using System.ComponentModel.DataAnnotations;

namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela un vehiculo en general en el sistema 
     /// </summary>   
    public class Vehiculo
    {
        // Identificador único de cada vehiculo
        public int id { get; set; }
        [Required, StringLength(50)]
        public string placa { get; set; }
        [Required, StringLength(50)]
        public TipoVehiculo tipoVehiculo { set; get; }

    }
}
