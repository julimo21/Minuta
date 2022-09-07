using System;
using Minuta.App.Persistencia;
using Minuta.App.Dominio;

namespace Minuta.App.Consola
{
    internal class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Minuta.App.Persistencia.AppContext());
        private static void Main(string[] args)
        {
            Console.WriteLine("Hola para todos");            
            //AddPersona();
            //BuscarPersona(5);
            //EliminarPersona(6);
            UpdatePersona(1);
            
        }

        private static void AddPersona()
        {
            Console.WriteLine("Escriba su nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Escriba su apellido:");
            string ape = Console.ReadLine();
            Console.WriteLine("Escriba su cedula:");
            string ced = Console.ReadLine();
            var persona = new Persona
            {
                nombre = nom,
                apellidos = ape,
                cedula = ced
            };

            _repoPersona.AddPersona(persona);
        }

        private static void BuscarPersona(int idp)
        {
            var pers = _repoPersona.GetPersona(idp);
            Console.WriteLine(pers.nombre + " " + pers.apellidos + " - C.C. " + pers.cedula);
        }

        private static void EliminarPersona(int idp)
        {
            _repoPersona.DeletePersona(idp);
            Console.WriteLine("Persona eliminada correctamente.");
        }

        private static void UpdatePersona(int idp)
        {
            var pers = _repoPersona.GetPersona(idp);
            if (pers != null)
            {
                
            }
            Console.WriteLine("Escriba su nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Escriba su apellido:");
            string ape = Console.ReadLine();
            Console.WriteLine("Escriba su cedula:");
            string ced = Console.ReadLine();
            /*var persona = new Persona
            {
                nombre = nom,
                apellidos = ape,
                cedula = ced
            };

            _repoPersona.AddPersona(persona);*/
        }
    }
}