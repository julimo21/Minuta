using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioVisitante
    {
        IEnumerable<Visitante> GetAllVisitante();

        Persona AddVisitante(Visitante visitante);
        Persona GetVisitante(int idVisitante);
        Persona UpdateVisitante(Visitante visitante);
        void DeleteVisitante(int idVisitante);
    }
}