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
        [Required(ErrorMessage = "Debe ingresar la placa del vehículo")]
        public string placa { get; set; }
        [Required(ErrorMessage = "Debe ingresar el tipo de vehículo")]
        public TipoVehiculo tipoVehiculo { set; get; }

    }
}
