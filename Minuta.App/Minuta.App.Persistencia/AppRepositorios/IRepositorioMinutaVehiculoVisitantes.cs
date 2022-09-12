using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioMinutaVehiculoVisitantes
    {
        IEnumerable<MinutaVehiculoVisitantes> GetAllMinutaVehiculoVisitantes();

        MinutaVehiculoVisitantes AddMinutaVehiculoVisitantes(MinutaVehiculoVisitantes minutaVehiculoVisitantes);
        MinutaVehiculoVisitantes GetMinutaVehiculoVisitantes(int idMinutaVehiculoVisitantes);
        MinutaVehiculoVisitantes UpdateMinutaVehiculoVisitantes(MinutaVehiculoVisitantes minutaVehiculoVisitantes);
        void DeleteMinutaVehiculoVisitantes(int idMinutaVehiculoVisitantes);
    }
}