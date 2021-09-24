using System;

namespace HospitalEnCasa.App.Dominio
{
    public class FamiliarDesignado:Persona
    {
        public int ID_FamiliarDesignado { get; set; }
        public String Parentezco { get;set; }
        
        //Constructor de la clase
        public FamiliarDesignado(int iD_FamiliarDesignado, String parentezco) 
        {
            this.ID_FamiliarDesignado = iD_FamiliarDesignado;
            this.Parentezco = parentezco;
               
        }
    }
    /* Pendiente por implementar crud
    //Metodo para registar los signos vitales de los pacientes
    public void registarSignosVitales()
    {

    }
    //Metodo para consultar los signos vitales de los pacientes
    public void consultarSignosVitales()
    {

    }
    //Metodo para actualizar los signos vitales de los pacientes
    public void actualizarSignosVitales()
    {

    }*/
}