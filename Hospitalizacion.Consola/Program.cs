// See https://aka.ms/new-console-template for more information
using System;
using Hospitalizacion.Dominio;
using Hospitalizacion.Persistencia;

namespace Hospitalizacion.Consola{
    class program{

        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args){
            Console.WriteLine("Hello, World!");
            AddPaciente();
            // BuscarPaciente(1);
        }

        private static void AddPaciente(){
            var paciente = new Paciente{
                // Nombre = "Nicolay",
                Nombre = "Santiraf",
                // Apellidos = "Perez",
                Apellidos = "Perez",
                NumeroTelefono = "3105238753",
                Genero = Genero.Intersexual,
                Direccion = "Carrera 3 no 43 - 2 sur ",
                Longitud = 6.0363543F,
                Latitud = -76.4334525F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1991,03,11)
            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void BuscarPaciente(int idPaciente){
            Console.WriteLine("Buscando ...");
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
    }
}