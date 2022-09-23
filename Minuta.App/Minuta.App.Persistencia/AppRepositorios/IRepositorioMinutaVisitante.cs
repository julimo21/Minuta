using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMinutaVisitante
    {
        IEnumerable<MinutaVisitante> GetAllMinutaVisitante();

        MinutaVisitante AddMinutaVisitante(MinutaVisitante minutaVisitante, string cedulaVisitante);
        MinutaVisitante GetMinutaVisitante(int idMinutaVisitante);
        MinutaVisitante UpdateMinutaVisitante(MinutaVisitante minutaVisitante, string cedulaVisitante);
        void DeleteMinutaVisitante(int idMinutaVisitante);
    }
}