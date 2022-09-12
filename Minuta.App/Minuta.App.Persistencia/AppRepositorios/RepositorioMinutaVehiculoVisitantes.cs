using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioMinutaVehiculoVisitantes:IRepositorioMinutaVehiculoVisitantes
    {
        private readonly AppContext appcox;

        public RepositorioMinutaVehiculoVisitantes(AppContext appContext)
        {
            appcox = appContext;
        }
        IEnumerable<MinutaVehiculoVisitantes> IRepositorioMinutaVehiculoVisitantes.GetAllMinutaVehiculoVisitantes()
        {
            return appcox.minVehVis;
        }
        MinutaVehiculoVisitantes IRepositorioMinutaVehiculoVisitantes.AddMinutaVehiculoVisitantes(Minuta.App.Dominio.MinutaVehiculoVisitantes minutaVehiculoVisitantes)
        {
            var AgregarMinutaVehiculoVisitantes = appcox.minVehVis.Add(minutaVehiculoVisitantes);
            appcox.SaveChanges();

            return AgregarMinutaVehiculoVisitantes.Entity;
        }
        MinutaVehiculoVisitantes IRepositorioMinutaVehiculoVisitantes.GetMinutaVehiculoVisitantes(int idMinutaVehiculoVisitantes)
        {
            return appcox.minVehVis.FirstOrDefault(v => v.id == idMinutaVehiculoVisitantes);
        }
        MinutaVehiculoVisitantes IRepositorioMinutaVehiculoVisitantes.UpdateMinutaVehiculoVisitantes(Minuta.App.Dominio.MinutaVehiculoVisitantes minutaVehiculoVisitantes)
        {
            var MinutaVehiculoVisitantesEncontrar = appcox.minVehVis.FirstOrDefault(v => v.id == minutaVehiculoVisitantes.id);

            if(MinutaVehiculoVisitantesEncontrar != null)
            {
                //campos que vienen de persona
                MinutaVehiculoVisitantesEncontrar.fecha = minutaVehiculoVisitantes.fecha;
                MinutaVehiculoVisitantesEncontrar.hora = minutaVehiculoVisitantes.hora;
                MinutaVehiculoVisitantesEncontrar.asunto = minutaVehiculoVisitantes.asunto;
                //campos que vienen de minutaVehiculoVisitantes
                MinutaVehiculoVisitantesEncontrar.visitante = minutaVehiculoVisitantes.visitante;
                MinutaVehiculoVisitantesEncontrar.vehiculoVis = minutaVehiculoVisitantes.vehiculoVis;
                MinutaVehiculoVisitantesEncontrar.fechaSalidaVehVis = minutaVehiculoVisitantes.fechaSalidaVehVis;
                MinutaVehiculoVisitantesEncontrar.horaSalidaVehVis = minutaVehiculoVisitantes.horaSalidaVehVis;
                MinutaVehiculoVisitantesEncontrar.numParqueaderoVis = minutaVehiculoVisitantes.numParqueaderoVis;

                appcox.SaveChanges();                
            }
            return MinutaVehiculoVisitantesEncontrar;
        }
        void IRepositorioMinutaVehiculoVisitantes.DeleteMinutaVehiculoVisitantes(int idMinutaVehiculoVisitantes)
        {
            var MinutaVehiculoVisitantesEncontrar = appcox.minVehVis.FirstOrDefault(v => v.id == idMinutaVehiculoVisitantes);

            if(MinutaVehiculoVisitantesEncontrar == null)
            {
                return;
            }

            appcox.minVehVis.Remove(MinutaVehiculoVisitantesEncontrar);
            appcox.SaveChanges();
        }
    }
}