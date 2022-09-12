using System.Collections.Generic;
using Minuta.App.Dominio;

namespace Minuta.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPrueba
    {
        //Semana 4 parte 1
        IEnumerable<Vehiculo> GetAll();
        //Semana 4 parte 2
        IEnumerable<Vehiculo> GetVehiculoPorFiltro(string filtro);
        Vehiculo GetVehiculoPorId(int vehiculoId);
    }
}