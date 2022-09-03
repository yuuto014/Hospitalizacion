﻿using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World EF!");
            //  AddPaciente();
            // Console.WriteLine("Buscando primer paciente...");
            // BuscarPaciente(1);
            // DeletePaciente(5);
            // UpdatePaciente(6);
            // GetAllPacientes();
            //Console.WriteLine("Ya había un paciente Nicolay Perez, ahora agregaré Nicolay2 Perez2 y los demás datos iguales solo para probar que borrar paciente funciona...");
            //AddPaciente();
            //Console.WriteLine("Buscando segundo paciente...");
            //BuscarPaciente(3);
            //Console.WriteLine("Borrando segundo paciente...");
            //DeletePaciente(2);
            //Paciente paciente_original = BuscarPaciente(1);
            //Paciente paciente_actualizado = UpdatePaciente(paciente_original); //estoy poniendo la info de Nicolay Perez de id1 en id2
            //Paciente paciente_actualizado = UpdatePaciente(AddPaciente()); //estoy poniendo la info de Nicolay Perez de id1 en id2
            //UpdatePaciente(5); //estoy actualizando Nicolay5 Perez5 de la id5 que tenía Nicolay3 Perez3
            // GetAllPacientes();            
            //Console.WriteLine("Buscando paciente actualizado...");
            //BuscarPaciente(3);


            //AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Nicolay",
                Apellidos = "Perez",                
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
            Console.WriteLine("El paciente "+ paciente.Nombre+" se agrego");
        }
      
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            //Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
            string datos_paciente = "\nNombre: "+paciente.Nombre+"\nApellidos: "+paciente.Apellidos+"\nNumero de Telefono: "+paciente.NumeroTelefono+"\nGenero: "+paciente.Genero+"\nDireccion: "+paciente.Direccion+"\nUbicacion (Longitud;Latitud): ("+paciente.Longitud+";"+paciente.Latitud+")"+"\nCiudad: "+paciente.Ciudad+"\nFecha de Nacimiento: "+paciente.FechaNacimiento;
            Console.WriteLine(datos_paciente);      
        }

        private static void DeletePaciente(int idPaciente)
        {        
            string nombrePaciente = _repoPaciente.GetPaciente(idPaciente).Nombre;
            Console.WriteLine("Borrando paciente "+ nombrePaciente +"...\n");     
            _repoPaciente.DeletePaciente(idPaciente); 
            Console.WriteLine("Paciente "+ nombrePaciente+ " borrado!");                  
        }
        
        private static void UpdatePaciente(int idPaciente_original)
        {            
            //var paciente_actualizado = _repoPaciente.UpdatePaciente(paciente);
            var paciente_actualizado = new Paciente
            {
                
                //Nombre = "Nicolay",
                //Apellidos = "Perez",
                //Nombre = "Nicolay2",
                //Apellidos = "Perez2",
                Nombre = "Nicolay6",
                Apellidos = "Perez6",                
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.UpdatePaciente(paciente_actualizado, idPaciente_original);
            //var paciente = _repoPaciente.UpdatePaciente(idPaciente);

            Console.WriteLine("Paciente "+ paciente_actualizado.Nombre+" actualizado!");
            //return paciente_actualizado;           
                
        }
      
        private static void GetAllPacientes()
        {
          var pacientes = _repoPaciente.GetAllPacientes();          
          Console.WriteLine("Lista de pacientes:\n");    
          foreach(var paciente in pacientes){
            Console.WriteLine(paciente.Id + " - " + paciente.Nombre);
          }
        }
    }
}