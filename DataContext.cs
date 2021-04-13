using Microsoft.EntityFrameworkCore;

namespace api
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Pet> Pets {get;set;}
        public DbSet<DonoPet> DonoPets {get;set;}
        public DbSet<Atendimento> Atendimentos {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                        
            Pet.ConfigEntities(modelBuilder);
            DonoPet.ConfigEntities(modelBuilder);
            Atendimento.ConfigEntities(modelBuilder);
        }    

       
          
    }
}