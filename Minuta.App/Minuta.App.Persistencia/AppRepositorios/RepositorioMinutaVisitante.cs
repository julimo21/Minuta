using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public class RepositorioMinutaVisitante:IRepositorioMinutaVisitante
    {
        /*private readonly AppContext appcox;

        public RepositorioMinutaVisitante(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<MinutaVisitante> IRepositorioMinutaVisitante.GetAllMinutaVisitante()
        {
            return appcox.minVis.Include(v => v.visitante);
        }
        MinutaVisitante IRepositorioMinutaVisitante.AddMinutaVisitante(Minuta.App.Dominio.MinutaVisitante minutaVisitante)
        {
            var AgregarMinutaVisitante = appcox.minVis.Add(minutaVisitante);
            appcox.SaveChanges();

            return AgregarMinutaVisitante.Entity;
        }
        MinutaVisitante IRepositorioMinutaVisitante.GetMinutaVisitante(int idMinutaVisitante)
        {
            return appcox.minVis.FirstOrDefault(mv => mv.id == idMinutaVisitante);
        }
        MinutaVisitante IRepositorioMinutaVisitante.UpdateMinutaVisitante(Minuta.App.Dominio.MinutaVisitante minutaVisitante, string cedulaVisitante)
        {
            var MinutaVisitanteEncontrar = appcox.minVis.Include(v => v.visitante).FirstOrDefault(mv => mv.id == minutaVisitante.id);

            if(MinutaVisitanteEncontrar != null)
            {                
                var nuevoVisitante = appcox.vis.FirstOrDefault(v => v.cedula == cedulaVisitante);
                //campos que vienen de minuta vigilancia
                MinutaVisitanteEncontrar.fecha = minutaVisitante.fecha;
                MinutaVisitanteEncontrar.hora = minutaVisitante.hora;
                MinutaVisitanteEncontrar.asunto = minutaVisitante.asunto;                
                //campos que vienen de minuta visitante
                MinutaVisitanteEncontrar.visitante = nuevoVisitante;
                MinutaVisitanteEncontrar.fechaSalidaVis = minutaVisitante.fechaSalidaVis;
                MinutaVisitanteEncontrar.horaSalidaVis = minutaVisitante.horaSalidaVis;

                appcox.SaveChanges();                
            }
            return MinutaVisitanteEncontrar;
        }
        void IRepositorioMinutaVisitante.DeleteMinutaVisitante(int idMinutaVisitante)
        {
            var MinutaVisitanteEncontrar = appcox.minVis.FirstOrDefault(mv => mv.id == idMinutaVisitante);

            if(MinutaVisitanteEncontrar == null)
            {
                return;
            }

            appcox.minVis.Remove(MinutaVisitanteEncontrar);
            appcox.SaveChanges();
        }
    }
}