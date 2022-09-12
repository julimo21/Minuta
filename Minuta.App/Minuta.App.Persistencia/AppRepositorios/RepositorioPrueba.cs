using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public class RepositorioPrueba : IRepositorioPrueba
    {
        List<Vehiculo> vehiculos;
        public RepositorioPrueba()
        {
            vehiculos = new List<Vehiculo>()
            {
                new Vehiculo{id=1, placa="ASD-123", tipoVehiculo = (TipoVehiculo.Moto)},
                //new Saludo{Id=2, Espanol="Buenas tardes", Ingles="Good afternoon", Italiano="Buona serata"},
                //new Saludo{Id=3, Espanol="Buenas noches", Ingles="Good evening", Italiano="Buona notte"}
            };
        }
        public IEnumerable<Vehiculo> GetAll()
        {
            return vehiculos;
        }

        public Vehiculo GetVehiculoPorId(int vehiculoId)
        {
            return vehiculos.SingleOrDefault(v => v.id == vehiculoId);
        }

        public IEnumerable<Vehiculo> GetVehiculoPorFiltro(string filtro = null)
        {
            throw new NotImplementedException();
            /*var saludos = GetAll(); // Obtiene todos los saludos
            if (saludos != null) //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    saludos = saludos.Where(s => s.Espanol.Contains(filtro));
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return saludos;*/

        }
    }
}