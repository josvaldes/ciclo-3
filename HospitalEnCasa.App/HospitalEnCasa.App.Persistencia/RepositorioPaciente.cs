using System.Collections.Generic;
using System.Linq;
using HospitalEnCasa.App.Dominio;

namespace HospitalEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {

        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Paciente IRepositorioPaciente.GetPacienteById(int Identificacion)
        {
            Paciente pacienteEncontrado0 = _appContext.Pacientes.FirstOrDefault(p => p.Identificacion == Identificacion);
            return pacienteEncontrado0;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            Paciente pacienteAdicionado = _appContext.Pacientes.Add(paciente).Entity;
            _appContext.SaveChanges();
            return pacienteAdicionado;
        }





        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            Paciente pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Identificacion == paciente.Identificacion);
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Identificacion = paciente.Identificacion;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.celular = paciente.celular;
                pacienteEncontrado.Genero = paciente.Genero;
                pacienteEncontrado.Ciudad = paciente.Ciudad;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
        }


        void IRepositorioPaciente.DeletePaciente(int Identificacion)
        {
            Paciente pacienteEncontradoDelete = _appContext.Pacientes.FirstOrDefault(p => p.Identificacion == Identificacion);
            if (pacienteEncontradoDelete != null)
            {
                _appContext.Pacientes.Remove(pacienteEncontradoDelete);
                _appContext.SaveChanges();
            }


        }


    }

}