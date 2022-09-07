using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioVisitante:IRepositorioVisitante
    {
        private readonly AppContext appcox;

        public RepositorioVisitante(AppContext appContext)
        {
            appcox = appContext;
        }
        IEnumerable<Visitante> IRepositorioVisitante.GetAllVisitante()
        {
            return appcox.vis;
        }
        Visitante IRepositorioVisitante.AddVisitante(Minuta.App.Dominio.Visitante visitante)
        {
            var AgregarVisitante = appcox.vis.Add(visitante);
            appcox.SaveChanges();

            return AgregarVisitante.Entity;
        }
        Visitante IRepositorioVisitante.GetVisitante(int idVisitante)
        {
            return appcox.vis.FirstOrDefault(v => v.id == idVisitante);
        }
        Visitante IRepositorioVisitante.UpdateVisitante(Minuta.App.Dominio.Visitante visitante)
        {
            var VisitanteEncontrar = appcox.vis.FirstOrDefault(v => v.id == visitante.id);

            if(VisitanteEncontrar != null)
            {
                VisitanteEncontrar.nombre = visitante.nombre;
                VisitanteEncontrar.apellidos = visitante.apellidos;
                VisitanteEncontrar.cedula = visitante.cedula;
                VisitanteEncontrar.numApartamentoVis = visitante.numApartamentoVis;

                appcox.SaveChanges();                
            }
            return VisitanteEncontrar;
        }
        void IRepositorioVisitante.DeleteVisitante(int idVisitante)
        {
            var VisitanteEncontrar = appcox.vis.FirstOrDefault(v => v.id == idVisitante);

            if(VisitanteEncontrar == null)
            {
                return;
            }

            appcox.vis.Remove(VisitanteEncontrar);
            appcox.SaveChanges();
        }
    }
}