using System;
using Minuta.App.Persistencia;
using Minuta.App.Dominio;

namespace Minuta.App.Consola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hola para todos");
            //AddVisitante();
            //BuscarVisitante(5);
            //EliminarVisitante(6);
            //UpdateVisitante(7);

        }
        
        /*private static IRepositorioVisitante _repoVisitante = new RepositorioVisitante(new Minuta.App.Persistencia.AppContext());
        private static void Main(string[] args)
        {
            Console.WriteLine("Hola para todos");
            //AddVisitante();
            //BuscarVisitante(5);
            //EliminarVisitante(6);
            UpdateVisitante(7);

        }

        private static void AddVisitante()
        {
            Console.WriteLine("Digite su nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Digite su apellido:");
            string ape = Console.ReadLine();
            Console.WriteLine("Digite su cedula:");
            string ced = Console.ReadLine();
            Console.WriteLine("Digite el numero de apartamento a visitar:");
            string num = Console.ReadLine();
            var visitante = new Visitante
            {
                nombre = nom,
                apellidos = ape,
                cedula = ced,
                numApartamentoVis = num
            };

            _repoVisitante.AddVisitante(visitante);
        }

        private static void BuscarVisitante(int idv)
        {
            var visi = _repoVisitante.GetVisitante(idv);
            Console.WriteLine("Visitante: " + visi.nombre + " " + visi.apellidos + " C.C. " + visi.cedula);
        }

        private static void EliminarVisitante(int idv)
        {
            _repoVisitante.DeleteVisitante(idv);
            Console.WriteLine("Visitante eliminado correctamente.");
        }

        private static void UpdateVisitante(int idv)
        {
            var visi = _repoVisitante.GetVisitante(idv);
            if (visi != null)
            {
                Console.WriteLine("Escriba su nombre:");
                string nom = Console.ReadLine();
                Console.WriteLine("Escriba su apellido:");
                string ape = Console.ReadLine();
                Console.WriteLine("Escriba su cedula:");
                string ced = Console.ReadLine();
                Console.WriteLine("Digite el numero de apartamento a visitar:");
                string num = Console.ReadLine();

                visi.nombre = nom;
                visi.apellidos = ape;
                visi.cedula = ced;
                visi.numApartamentoVis = num;
                
                _repoVisitante.UpdateVisitante(visi);
            }


            /*Console.WriteLine("Escriba su nombre:");
            string nom = Console.ReadLine();
            Console.WriteLine("Escriba su apellido:");
            string ape = Console.ReadLine();
            Console.WriteLine("Escriba su cedula:");
            string ced = Console.ReadLine();
            Console.WriteLine("Digite el numero de apartamento a visitar:");
            string num = Console.ReadLine();
            /*var persona = new Persona
            {
                nombre = nom,
                apellidos = ape,
                cedula = ced
            };

            _repoPersona.AddPersona(persona);
        }*/
    }
}