using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMinutaCorrespondencia
    {
        IEnumerable<MinutaCorrespondencia> GetAllMinutaCorrespondencia();

        MinutaCorrespondencia AddMinutaCorrespondencia(MinutaCorrespondencia minutaCorrespondencia);
        MinutaCorrespondencia GetMinutaCorrespondencia(int idMinutaCorrespondencia);
        MinutaCorrespondencia UpdateMinutaCorrespondencia(MinutaCorrespondencia minutaCorrespondencia);
        void DeleteMinutaCorrespondencia(int idMinutaCorrespondencia);
    }
}