using System.Collections.Generic;
using System.Linq;
using Hospitalizacion.Dominio;

namespace Hospitalizacion.Persistencia{
    public class RepositorioPaciente : IRepositorioPaciente{

        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appcontext){
            _appContext = appcontext;
        }
        public Paciente AddPaciente(Paciente paciente){
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente){
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Paciente> getAllPacientes(){
            return _appContext.Pacientes;
        }

        public Paciente GetPaciente(int idPaciente){
            // Console.WriteLine(_appContext.Pacientes.FirstOrDefault(Paciente 1));
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        }

        public Paciente UpdatePaciente(Paciente paciente){
            var pacienteEncontrado = GetPaciente(paciente.Id);
            if(getAllPacientes != null){
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Latitud = paciente.Latitud;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Familiar = paciente.Familiar;
                pacienteEncontrado.Enfermera = paciente.Enfermera;
                pacienteEncontrado.Medico = paciente.Medico;
                pacienteEncontrado.Historia = paciente.Historia;
                
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}