using Microsoft.EntityFrameworkCore;
using Minuta.App.Dominio;
namespace Minuta.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> per {get;set;}
        //public DbSet<Usuario> usu {get;set;}
        //public DbSet<RolUsuario> tipUsu {get;set;}
        public DbSet<Administrador> adm {get;set;}
        public DbSet<Vigilante> vig {get;set;}
        public DbSet<Residente> res {get;set;}        
        public DbSet<Visitante> vis {get;set;}
        public DbSet<Vehiculo> veh {get;set;}      
        //public DbSet<TipoVehiculo> tipVeh {get;set;}   
        public DbSet<MinutaVigilancia> minVig {get;set;}
        public DbSet<MinutaVisitante> minVis {get;set;}
        public DbSet<MinutaEventos> minEve {get;set;}
        public DbSet<MinutaCorrespondencia> minCor {get;set;}
        public DbSet<MinutaVehiculoVisitantes> minVehVis {get;set;}
        public DbSet<MinutaVehiculoResidentes> minVehRes {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MinutaData");
                }
            }
    }
}