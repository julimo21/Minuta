using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia
{
    public interface IRepositorioMinutaVehiculoResidentes
    {
        IEnumerable<MinutaVehiculoResidentes> GetAllMinutaVehiculoResidentes();

        MinutaVehiculoResidentes AddMinutaVehiculoResidentes(MinutaVehiculoResidentes minutaVehiculoResidentes);
        MinutaVehiculoResidentes GetMinutaVehiculoResidentes(int idMinutaVehiculoResidentes);
        MinutaVehiculoResidentes UpdateMinutaVehiculoResidentes(MinutaVehiculoResidentes minutaVehiculoResidentes);
        void DeleteMinutaVehiculoResidentes(int idMinutaVehiculoResidentes);
    }
}