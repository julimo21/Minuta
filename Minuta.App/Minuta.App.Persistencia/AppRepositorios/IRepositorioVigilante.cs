using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioVisitante
    {
        IEnumerable<Visitante> GetAllVisitante();

        Visitante AddVisitante(Visitante visitante);
        Visitante GetVisitante(int idVisitante);
        Visitante UpdateVisitante(Visitante visitante);
        void DeleteVisitante(int idVisitante);
    }
}