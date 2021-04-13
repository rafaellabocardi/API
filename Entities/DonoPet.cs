using System;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class DonoPet
    {
        public int DonoPetId {get;set;}
        public string Nome {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public Pet Pet {get;set;}
        
        public static void ConfigEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonoPet>( etd=>
            {
                etd.HasKey(c => c.DonoPetId);
                etd.Property(c => c.DonoPetId).ValueGeneratedOnAdd();
            });    
            modelBuilder.Entity<DonoPet>().ToTable("DonoPets");   
        }
    
    }
}