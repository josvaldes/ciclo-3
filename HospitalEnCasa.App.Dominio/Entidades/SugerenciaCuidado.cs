using System;

namespace HospitalEnCasa.App.Dominio
{
    public class SugerenciaCuidado:Persona
    {
        public int ID_SugerenciaCuidado { get; set; }
        public int ID_Paciente { get; set; }   
        public int ID_Enfermeria { get; set; } 
        public int ID_Medico { get; set; }     
        public String FechaSugerencia { get;set; }
        public String FormulaMedica { get;set; }
        public String Observaciones { get;set; }
       
        
        /*
        //Composicion con la clase Paciente
        private Paciente Paciente { get;set; }

        //Composicion con la clase Enfermeria
        private Enfermeria Enfermera { get;set; }

        //Composicion con la clase Medico
        private Medico Medico { get;set; }
        
        
        //Constructor de la clase
        public SugerenciaCuidado(int iD_SugerenciaCuidado, int iD_Paciente, int iD_Enfermeria, int iD_Medico, String fechaSugerencia, String formulaMedica, String observaciones, Paciente paciente, Enfermeria enfermera, Medico medico) 
        {
            this.ID_SugerenciaCuidado = iD_SugerenciaCuidado;
            this.ID_Paciente = iD_Paciente;
            this.ID_Enfermeria = iD_Enfermeria;
            this.ID_Medico = iD_Medico;
            this.FechaSugerencia = fechaSugerencia;
            this.FormulaMedica = formulaMedica;
            this.Observaciones = observaciones;
            this.Paciente = paciente;
            this.Enfermera = enfermera;
            this.Medico = medico;   
        }*/

   
    }

    
}