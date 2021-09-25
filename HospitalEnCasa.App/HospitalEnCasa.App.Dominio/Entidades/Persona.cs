using System;

namespace HospitalEnCasa.App.Dominio
{
    //[Keyless]
    public class Persona
    {
        public int id { get; set; }
        public int Identificacion { get; set; }
        public String Nombre { get;set; }
        public String Apellidos { get;set; }
        public String celular { get;set; }
        public Genero Genero { get;set; }
        /*
        public Persona(int iD, int identificacion, String nombre, String apellidos, String celular, Genero genero) 
        {
            this.ID = iD;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.celular = celular;
            this.Genero = genero;
               
        }*/
    }

    
}