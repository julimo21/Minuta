using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMinutaEventos
    {
        IEnumerable<MinutaEventos> GetAllMinutaEventos();

        MinutaEventos AddMinutaEventos(MinutaEventos minutaEventos);
        MinutaEventos GetMinutaEventos(int idMinutaEventos);
        MinutaEventos UpdateMinutaEventos(MinutaEventos minutaEventos);
        void DeleteMinutaEventos(int idMinutaEventos);
    }
}