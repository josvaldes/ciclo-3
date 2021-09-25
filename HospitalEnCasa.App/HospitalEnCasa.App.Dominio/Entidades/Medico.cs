using System;

namespace HospitalEnCasa.App.Dominio
{
    public class Medico: Persona
    {
        public int ID_Medico { get; set; }
        public String Tarjeta_Profesional { get;set; }
        public String Especialidad { get;set; }
        /*
        //Constructor de la clase
        public Medico(int iD_Medico, String tarjeta_Profesional, String especialidad) 
        {
            this.ID_Medico = iD_Medico;
            this.Tarjeta_Profesional = tarjeta_Profesional;
            this.Especialidad = especialidad;
               
        }*/
        
    }
    
    
}