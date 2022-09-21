using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioVigilante:IRepositorioVigilante
    {
        /*private readonly AppContext appcox;

        public RepositorioVigilante(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<Vigilante> IRepositorioVigilante.GetAllVigilante()
        {
            return appcox.vig;
        }
        Vigilante IRepositorioVigilante.AddVigilante(Minuta.App.Dominio.Vigilante vigilante)
        {
            var AgregarVigilante = appcox.vig.Add(vigilante);
            appcox.SaveChanges();

            return AgregarVigilante.Entity;
        }
        Vigilante IRepositorioVigilante.GetVigilante(int idVigilante)
        {
            return appcox.vig.FirstOrDefault(v => v.id == idVigilante);
        }
        Vigilante IRepositorioVigilante.UpdateVigilante(Minuta.App.Dominio.Vigilante vigilante)
        {
            var VigilanteEncontrar = appcox.vig.FirstOrDefault(v => v.id == vigilante.id);

            if(VigilanteEncontrar != null)
            {
                //campos que vienen de persona
                VigilanteEncontrar.nombre = vigilante.nombre;
                VigilanteEncontrar.apellidos = vigilante.apellidos;
                VigilanteEncontrar.cedula = vigilante.cedula;
                //campos que vienen de usuario
                /*VigilanteEncontrar.idUsuario = vigilante.idUsuario;
                VigilanteEncontrar.contrasena = vigilante.contrasena;
                VigilanteEncontrar.tipo = vigilante.tipo;*/
                //campos que vienen de vigilante
                VigilanteEncontrar.empresa = vigilante.empresa;
                VigilanteEncontrar.turno = vigilante.turno;

                appcox.SaveChanges();                
            }
            return VigilanteEncontrar;
        }
        void IRepositorioVigilante.DeleteVigilante(int idVigilante)
        {
            var VigilanteEncontrar = appcox.vig.FirstOrDefault(v => v.id == idVigilante);

            if(VigilanteEncontrar == null)
            {
                return;
            }

            appcox.vig.Remove(VigilanteEncontrar);
            appcox.SaveChanges();
        }
    }
}