using Microsoft.EntityFrameworkCore;
using HospitalEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospitalEnCasa.App.Persistencia 
{
    public class AppContext : DbContext
    {
        //internal IEnumerable<Paciente> GetAllPacientes;

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        /*
        public object Pacientes { get; internal set; }

        /* public ApplicationContext()
         {
             Database.EnsureCreated();
         }*/
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;password=;database=HospitalEnCasaBD2;");
            }
        }  
         protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Persona>()
                .HasIndex(u => u.Identificacion)
                .IsUnique();
        }    

    }
}