using System.Collections.Generic;
using Hospitalizacion.Dominio;

namespace Hospitalizacion.Persistencia{
    public interface IRepositorioPaciente{
        IEnumerable<Paciente> getAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
    }
}