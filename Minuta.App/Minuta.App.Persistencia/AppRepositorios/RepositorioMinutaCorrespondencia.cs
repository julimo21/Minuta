using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public class RepositorioMinutaCorrespondencia:IRepositorioMinutaCorrespondencia
    {
        /*private readonly AppContext appcox;

        public RepositorioMinutaCorrespondencia(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<MinutaCorrespondencia> IRepositorioMinutaCorrespondencia.GetAllMinutaCorrespondencia()
        {
            return appcox.minCor.Include(r => r.residente);
        }
        MinutaCorrespondencia IRepositorioMinutaCorrespondencia.AddMinutaCorrespondencia(Minuta.App.Dominio.MinutaCorrespondencia minutaCorrespondencia, string cedulaResidente)
        {
            var nuevoResidente = appcox.res.FirstOrDefault(r => r.cedula == cedulaResidente);
            minutaCorrespondencia.residente = nuevoResidente;
            var AgregarMinutaCorrespondencia = appcox.minCor.Add(minutaCorrespondencia);
            appcox.SaveChanges();

            return AgregarMinutaCorrespondencia.Entity;
        }
        MinutaCorrespondencia IRepositorioMinutaCorrespondencia.GetMinutaCorrespondencia(int idMinutaCorrespondencia)
        {
            return appcox.minCor.Include(mc => mc.residente).FirstOrDefault(mc => mc.id == idMinutaCorrespondencia);
        }
        MinutaCorrespondencia IRepositorioMinutaCorrespondencia.UpdateMinutaCorrespondencia(Minuta.App.Dominio.MinutaCorrespondencia minutaCorrespondencia, string cedulaResidente)
        {
            var MinutaCorrespondenciaEncontrar = appcox.minCor.Include(r => r.residente).FirstOrDefault(mc => mc.id == minutaCorrespondencia.id);

            if(MinutaCorrespondenciaEncontrar != null)
            {    
                var nuevoResidente = appcox.res.FirstOrDefault(r => r.cedula == cedulaResidente);            
                //campos que vienen de minuta vigilancia
                MinutaCorrespondenciaEncontrar.fecha = minutaCorrespondencia.fecha;
                MinutaCorrespondenciaEncontrar.hora = minutaCorrespondencia.hora;
                MinutaCorrespondenciaEncontrar.asunto = minutaCorrespondencia.asunto;                
                //campos que vienen de minuta correspondencia
                MinutaCorrespondenciaEncontrar.residente = nuevoResidente;
                MinutaCorrespondenciaEncontrar.tipoCorrespondencia = minutaCorrespondencia.tipoCorrespondencia;
                MinutaCorrespondenciaEncontrar.personaEntrega = minutaCorrespondencia.personaEntrega;
                MinutaCorrespondenciaEncontrar.personaRecibe = minutaCorrespondencia.personaRecibe;
                MinutaCorrespondenciaEncontrar.firmaRecibido = minutaCorrespondencia.firmaRecibido;
                MinutaCorrespondenciaEncontrar.observaciones = minutaCorrespondencia.observaciones;

                appcox.SaveChanges();                
            }
            return MinutaCorrespondenciaEncontrar;
        }
        void IRepositorioMinutaCorrespondencia.DeleteMinutaCorrespondencia(int idMinutaCorrespondencia)
        {
            var MinutaCorrespondenciaEncontrar = appcox.minCor.FirstOrDefault(mc => mc.id == idMinutaCorrespondencia);

            if(MinutaCorrespondenciaEncontrar == null)
            {
                return;
            }

            appcox.minCor.Remove(MinutaCorrespondenciaEncontrar);
            appcox.SaveChanges();
        }
    }
}