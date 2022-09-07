using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioResidente:IRepositorioResidente
    {
        private readonly AppContext appcox;

        public RepositorioResidente(AppContext appContext)
        {
            appcox = appContext;
        }
        IEnumerable<Residente> IRepositorioResidente.GetAllResidente()
        {
            return appcox.res;
        }
        Residente IRepositorioResidente.AddResidente(Minuta.App.Dominio.Residente residente)
        {
            var AgregarResidente = appcox.res.Add(residente);
            appcox.SaveChanges();

            return AgregarResidente.Entity;
        }
        Residente IRepositorioResidente.GetResidente(int idResidente)
        {
            return appcox.res.FirstOrDefault(v => v.id == idResidente);
        }
        Residente IRepositorioResidente.UpdateResidente(Minuta.App.Dominio.Residente residente)
        {
            var ResidenteEncontrar = appcox.res.FirstOrDefault(v => v.id == residente.id);

            if(ResidenteEncontrar != null)
            {
                //campos que vienen de persona
                ResidenteEncontrar.nombre = residente.nombre;
                ResidenteEncontrar.apellidos = residente.apellidos;
                ResidenteEncontrar.cedula = residente.cedula;
                //campos que vienen de usuario
                ResidenteEncontrar.idUsuario = residente.idUsuario;
                ResidenteEncontrar.contrasena = residente.contrasena;
                ResidenteEncontrar.tipo = residente.tipo;
                //campos que vienen de residente
                ResidenteEncontrar.numApartamentoRes = residente.numApartamentoRes;
                ResidenteEncontrar.numParqueaderoRes = residente.numParqueaderoRes;
                ResidenteEncontrar.celularRes = residente.celularRes;

                appcox.SaveChanges();                
            }
            return ResidenteEncontrar;
        }
        void IRepositorioResidente.DeleteResidente(int idResidente)
        {
            var ResidenteEncontrar = appcox.res.FirstOrDefault(v => v.id == idResidente);

            if(ResidenteEncontrar == null)
            {
                return;
            }

            appcox.res.Remove(ResidenteEncontrar);
            appcox.SaveChanges();
        }
    }
}