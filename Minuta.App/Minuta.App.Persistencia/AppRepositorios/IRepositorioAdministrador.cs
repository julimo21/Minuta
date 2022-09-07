using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
        IEnumerable<Administrador> GetAllAdministrador();

        Administrador AddAdministrador(Administrador administrador);
        Administrador GetAdministrador(int idAdministrador);
        Administrador UpdateAdministrador(Administrador administrador);
        void DeleteAdministrador(int idAdministrador);
    }
}