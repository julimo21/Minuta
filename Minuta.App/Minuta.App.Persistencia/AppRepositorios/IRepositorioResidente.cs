using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioResidente
    {
        IEnumerable<Residente> GetAllResidente();

        Residente AddResidente(Residente residente);
        Residente GetResidente(int idResidente);
        Residente UpdateResidente(Residente residente);
        void DeleteResidente(int idResidente);
    }
}