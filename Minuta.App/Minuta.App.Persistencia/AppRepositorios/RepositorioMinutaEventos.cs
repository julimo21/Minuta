using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public class RepositorioMinutaEventos:IRepositorioMinutaEventos
    {
        /*private readonly AppContext appcox;

        public RepositorioMinutaEventos(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<MinutaEventos> IRepositorioMinutaEventos.GetAllMinutaEventos()
        {
            return appcox.minEve;
        }
        MinutaEventos IRepositorioMinutaEventos.AddMinutaEventos(Minuta.App.Dominio.MinutaEventos minutaEventos)
        {
            var AgregarMinutaEventos = appcox.minEve.Add(minutaEventos);
            appcox.SaveChanges();

            return AgregarMinutaEventos.Entity;
        }
        MinutaEventos IRepositorioMinutaEventos.GetMinutaEventos(int idMinutaEventos)
        {
            return appcox.minEve.FirstOrDefault(me => me.id == idMinutaEventos);
        }
        MinutaEventos IRepositorioMinutaEventos.UpdateMinutaEventos(Minuta.App.Dominio.MinutaEventos minutaEventos)
        {
            var MinutaEventosEncontrar = appcox.minEve.FirstOrDefault(me => me.id == minutaEventos.id);

            if(MinutaEventosEncontrar != null)
            {                
                //campos que vienen de minuta vigilancia
                MinutaEventosEncontrar.fecha = minutaEventos.fecha;
                MinutaEventosEncontrar.hora = minutaEventos.hora;
                MinutaEventosEncontrar.asunto = minutaEventos.asunto;                
                //campos que vienen de minuta eventos
                MinutaEventosEncontrar.anotaciones = minutaEventos.anotaciones;                

                appcox.SaveChanges();                
            }
            return MinutaEventosEncontrar;
        }
        void IRepositorioMinutaEventos.DeleteMinutaEventos(int idMinutaEventos)
        {
            var MinutaEventosEncontrar = appcox.minEve.FirstOrDefault(me => me.id == idMinutaEventos);

            if(MinutaEventosEncontrar == null)
            {
                return;
            }

            appcox.minEve.Remove(MinutaEventosEncontrar);
            appcox.SaveChanges();
        }
    }
}