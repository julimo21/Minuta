using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMinutaCorrespondencia
    {
        IEnumerable<MinutaCorrespondencia> GetAllMinutaCorrespondencia();

        MinutaCorrespondencia AddMinutaCorrespondencia(MinutaCorrespondencia minutaCorrespondencia, string cedulaResidente);
        MinutaCorrespondencia GetMinutaCorrespondencia(int idMinutaCorrespondencia);
        MinutaCorrespondencia UpdateMinutaCorrespondencia(MinutaCorrespondencia minutaCorrespondencia, string cedulaResidente);
        void DeleteMinutaCorrespondencia(int idMinutaCorrespondencia);
    }
}