using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioVigilante
    {
        IEnumerable<Vigilante> GetAllVigilante();

        Vigilante AddVigilante(Vigilante vigilante);
        Vigilante GetVigilante(int idVigilante);
        Vigilante UpdateVigilante(Vigilante vigilante);
        void DeleteVigilante(int idVigilante);
    }
}