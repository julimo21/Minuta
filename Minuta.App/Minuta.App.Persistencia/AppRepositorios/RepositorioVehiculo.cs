using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;
using Minuta.App.Persistencia;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        /*private readonly AppContext appcox;

        public RepositorioVehiculo(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculo()
        {
            return appcox.veh;
        }
        Vehiculo IRepositorioVehiculo.AddVehiculo(Minuta.App.Dominio.Vehiculo vehiculo)
        {
            var AgregarVehiculo = appcox.veh.Add(vehiculo);
            appcox.SaveChanges();

            return AgregarVehiculo.Entity;
        }
        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return appcox.veh.FirstOrDefault(v => v.id == idVehiculo);
        }
        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Minuta.App.Dominio.Vehiculo vehiculo)
        {
            var VehiculoEncontrar = appcox.veh.FirstOrDefault(v => v.id == vehiculo.id);

            if(VehiculoEncontrar != null)
            {
                
                //campos que vienen de vehiculo
                VehiculoEncontrar.placa = vehiculo.placa;
                VehiculoEncontrar.tipoVehiculo = vehiculo.tipoVehiculo;

                appcox.SaveChanges();                
            }
            return VehiculoEncontrar;
        }
        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var VehiculoEncontrar = appcox.veh.FirstOrDefault(v => v.id == idVehiculo);

            if(VehiculoEncontrar == null)
            {
                return;
            }

            appcox.veh.Remove(VehiculoEncontrar);
            appcox.SaveChanges();
        }
    }
}