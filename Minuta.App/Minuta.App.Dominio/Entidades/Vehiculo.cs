using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Minuta.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela un vehiculo en general en el sistema 
     /// </summary>   
    public class Vehiculo
    {
        // Identificador único de cada vehiculo
        public int id { get; set; }
        [Required]
        public string placa { get; set; }
        [Required]
        public TipoVehiculo tipoVehiculo { set; get; }

    }
}
