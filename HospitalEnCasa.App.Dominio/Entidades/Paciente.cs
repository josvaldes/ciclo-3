using System;

namespace HospitalEnCasa.App.Dominio
{
    public class Paciente:Persona
    {
               
        public int ID_Medico { get; set; }
        public int ID_Enfermeria { get; set; }
        public int ID_FamiliarDesignado { get; set; }
        public String FechaNacimiento { get;set; }
        public String Direccion { get;set; }
        public String Ciudad{ get;set; }
        /*
        //Agregación con la clase familiar designado
        private FamiliarDesignado oFamiliarDesignado { get;set; } 

        //Agregación con la clase Enfermera
        private Enfermeria oEnfermera { get;set; } 

        //Agregación con la clase Medico
        private Medico oMedico { get;set; } 

        //Constructor de la clase
        public Paciente(int iD_Medico, int iD_Enfermeria, int iD_FamiliarDesignado, String fechaNacimiento, String direccion, String ciudad) 
        {
            this.ID_Medico = iD_Medico;
            this.ID_Enfermeria = iD_Enfermeria;
            this.ID_FamiliarDesignado = iD_FamiliarDesignado;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Ciudad = ciudad;    
               
        }

        public void AgregarFamiliarDesignado(FamiliarDesignado pFamiliarDesignado)
        {
        if(pFamiliarDesignado != null)
            oFamiliarDesignado=pFamiliarDesignado;
        }

        public void AgregarEnfermera(Enfermeria pEnfermera)
        {
        if(pEnfermera != null)
            oEnfermera=pEnfermera;
        }

        public void AgregarMedico(Medico pMedico)
        {
        if(pMedico != null)
            oMedico=pMedico;
        }*/
   
    }

    
}