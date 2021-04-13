using System;
using Microsoft.EntityFrameworkCore;

namespace api
{
    public class Atendimento
    {
        public int AtendimentoId {get;set;}
        public int Data {get;set;}
        public Pet Pet {get;set;}
        public double Preco {get;set;}
        public int numAtendimentos {get;set;}
        
        public static void ConfigEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendimento>( etd=>
            {
                etd.HasKey(c => c.AtendimentoId);
                etd.Property(c => c.AtendimentoId).ValueGeneratedOnAdd();
            });    
            modelBuilder.Entity<Atendimento>().ToTable("Atendimentos");   
        }
    
    }
}