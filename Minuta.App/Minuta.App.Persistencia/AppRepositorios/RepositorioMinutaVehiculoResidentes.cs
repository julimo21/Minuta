using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioMinutaVehiculoResidentes:IRepositorioMinutaVehiculoResidentes
    {
        private readonly AppContext appcox;

        public RepositorioMinutaVehiculoResidentes(AppContext appContext)
        {
            appcox = appContext;
        }
        IEnumerable<MinutaVehiculoResidentes> IRepositorioMinutaVehiculoResidentes.GetAllMinutaVehiculoResidentes()
        {
            return appcox.minVehRes;
        }
        MinutaVehiculoResidentes IRepositorioMinutaVehiculoResidentes.AddMinutaVehiculoResidentes(Minuta.App.Dominio.MinutaVehiculoResidentes minutaVehiculoResidentes)
        {
            var AgregarMinutaVehiculoResidentes = appcox.minVehRes.Add(minutaVehiculoResidentes);
            appcox.SaveChanges();

            return AgregarMinutaVehiculoResidentes.Entity;
        }
        MinutaVehiculoResidentes IRepositorioMinutaVehiculoResidentes.GetMinutaVehiculoResidentes(int idMinutaVehiculoResidentes)
        {
            return appcox.minVehRes.FirstOrDefault(v => v.id == idMinutaVehiculoResidentes);
        }
        MinutaVehiculoResidentes IRepositorioMinutaVehiculoResidentes.UpdateMinutaVehiculoResidentes(Minuta.App.Dominio.MinutaVehiculoResidentes minutaVehiculoResidentes)
        {
            var MinutaVehiculoResidentesEncontrar = appcox.minVehRes.FirstOrDefault(v => v.id == minutaVehiculoResidentes.id);

            if(MinutaVehiculoResidentesEncontrar != null)
            {
                //campos que vienen de persona
                MinutaVehiculoResidentesEncontrar.fecha = minutaVehiculoResidentes.fecha;
                MinutaVehiculoResidentesEncontrar.hora = minutaVehiculoResidentes.hora;
                MinutaVehiculoResidentesEncontrar.asunto = minutaVehiculoResidentes.asunto;
                //campos que vienen de minutaVehiculoResidentes
                MinutaVehiculoResidentesEncontrar.residente = minutaVehiculoResidentes.residente;
                MinutaVehiculoResidentesEncontrar.vehiculoRes = minutaVehiculoResidentes.vehiculoRes;
                MinutaVehiculoResidentesEncontrar.observaciones = minutaVehiculoResidentes.observaciones;

                appcox.SaveChanges();                
            }
            return MinutaVehiculoResidentesEncontrar;
        }
        void IRepositorioMinutaVehiculoResidentes.DeleteMinutaVehiculoResidentes(int idMinutaVehiculoResidentes)
        {
            var MinutaVehiculoResidentesEncontrar = appcox.minVehRes.FirstOrDefault(v => v.id == idMinutaVehiculoResidentes);

            if(MinutaVehiculoResidentesEncontrar == null)
            {
                return;
            }

            appcox.minVehRes.Remove(MinutaVehiculoResidentesEncontrar);
            appcox.SaveChanges();
        }
    }
}