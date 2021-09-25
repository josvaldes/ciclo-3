using System;

namespace HospitalEnCasa.App.Dominio
{
    public class Enfermeria:Persona
    {
        public int ID_Enfermeria { get; set; }
        public String Tarjeta_Profesional { get;set; }

        //Constructor de la clase
        public Enfermeria(int iD_Enfermeria, String tarjeta_Profesional) 
        {
            this.ID_Enfermeria = iD_Enfermeria;
            this.Tarjeta_Profesional = tarjeta_Profesional;
               
        }
    }
    
        
}
    /*Pendiente por implementar crud y metodos relacionados a la clase
    //Metodo para registar la sugerencia de cuidado de los pacientes
    public void crearSugerenciaCuidado()
    {

    }
    //Metodo para consultar los signos vitales de los pacientes
    public void consultarSignosVitales()
    {

    }
    
}*/