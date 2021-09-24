using System.Collections.Generic;
using HospitalEnCasa.App.Dominio;


namespace HospitalEnCasa.App.Persistencia 
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPacienteById(int Identificacion);
    }
}