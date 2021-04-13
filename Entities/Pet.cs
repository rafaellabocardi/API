using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class Pet
    {
        public int PetId {get;set;}
        public string Nome {get;set;}
        public string Tipo {get;set;}
        public string Porte {get;set;}

       

        public static void ConfigEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>( etd=>
            {
                etd.HasKey(c => c.PetId);
                etd.Property(c => c.PetId).ValueGeneratedOnAdd();
            });    
            modelBuilder.Entity<Pet>().ToTable("Pets");   
        }
    }
}