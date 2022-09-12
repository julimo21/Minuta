using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculo();

        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo GetVehiculo(int idVehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idVehiculo);
    }
}