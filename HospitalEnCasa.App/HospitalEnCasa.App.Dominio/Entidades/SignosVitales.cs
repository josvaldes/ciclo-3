using System;

namespace HospitalEnCasa.App.Dominio
{
    public class SignosVitales:Persona
    {
        public int ID_SignosVitales { get; set; }
        public int ID_Paciente { get; set; }        
        public String FechaCaptura { get;set; }
        public String Oximetria { get;set; }
        public String FrecuenciaRespiratoria{ get;set; }
        public String FrecuenciaCardiaca { get;set; }
        public String Temperatura { get;set;} 
        public String PresionArterial { get;set; }
        public String Glisemia { get;set; }
        /*
        //Composicion con la clase Paciente
        private Paciente Paciente { get;set; }
        
        
        //Constructor de la clase
        public SignosVitales(int iD_SignosVitales, int iD_Paciente, String fechaCaptura, String oximetria, String frecuenciaRespiratoria, String frecuenciaCardiaca, String temperatura, String presionArterial, String glisemia, Paciente paciente) 
        {
            this.ID_SignosVitales = iD_SignosVitales;
            this.ID_Paciente = iD_Paciente;
            this.FechaCaptura = fechaCaptura;
            this.Oximetria = oximetria;
            this.FrecuenciaRespiratoria = frecuenciaRespiratoria;
            this.FrecuenciaCardiaca = frecuenciaCardiaca;
            this.Temperatura = temperatura;
            this.PresionArterial = presionArterial;
            this.Glisemia = glisemia;
            this.Paciente = paciente;         
               
        }*/

   
    }

    
}