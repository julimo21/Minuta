using System.Collections.Generic;
using System.Linq;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public class RepositorioAdministrador:IRepositorioAdministrador
    {
        /*private readonly AppContext appcox;

        public RepositorioAdministrador(AppContext appContext)
        {
            appcox = appContext;
        }*/
        private AppContext appcox = new AppContext();
        IEnumerable<Administrador> IRepositorioAdministrador.GetAllAdministrador()
        {
            return appcox.adm;
        }
        Administrador IRepositorioAdministrador.AddAdministrador(Minuta.App.Dominio.Administrador administrador)
        {
            var AgregarAdministrador = appcox.adm.Add(administrador);
            appcox.SaveChanges();

            return AgregarAdministrador.Entity;
        }
        Administrador IRepositorioAdministrador.GetAdministrador(int idAdministrador)
        {
            return appcox.adm.FirstOrDefault(a => a.id == idAdministrador);
        }
        Administrador IRepositorioAdministrador.UpdateAdministrador(Minuta.App.Dominio.Administrador administrador)
        {
            var AdministradorEncontrar = appcox.adm.FirstOrDefault(a => a.id == administrador.id);

            if(AdministradorEncontrar != null)
            {
                //campos que vienen de persona
                AdministradorEncontrar.nombre = administrador.nombre;
                AdministradorEncontrar.apellidos = administrador.apellidos;
                AdministradorEncontrar.cedula = administrador.cedula;
                //campos que vienen de usuario
                /*AdministradorEncontrar.idUsuario = administrador.idUsuario;
                AdministradorEncontrar.contrasena = administrador.contrasena;
                AdministradorEncontrar.tipo = administrador.tipo;*/
                //campos que vienen de administrador
                AdministradorEncontrar.celularAdm = administrador.celularAdm;
                AdministradorEncontrar.correoAdm = administrador.correoAdm;

                appcox.SaveChanges();                
            }
            return AdministradorEncontrar;
        }
        void IRepositorioAdministrador.DeleteAdministrador(int idAdministrador)
        {
            var AdministradorEncontrar = appcox.adm.FirstOrDefault(a => a.id == idAdministrador);

            if(AdministradorEncontrar == null)
            {
                return;
            }

            appcox.adm.Remove(AdministradorEncontrar);
            appcox.SaveChanges();
        }
    }
}