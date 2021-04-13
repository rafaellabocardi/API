using System.Collections.Generic;
using System.Linq;
using api;
namespace api.Services
{
    public class PetService
    {        
        private readonly DataContext _context;
        public PetService(DataContext context)
        {
            _context = context;
        }

        public List<Pet> RetornarDados()
        {
             List<Pet> pets = _context.Pets.ToList();
             return pets;
        }

        public Pet InserirDados(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();

            return pet;
        }

        public Pet AlterarDados(Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();

            return pet;
        }

         public bool DeletarDados(int id)
        {
            Pet pet = _context.Pets.Where(x=>x.PetId==id).FirstOrDefault();
            if(pet==null)
            {
                return false;
            }
            _context.Pets.Remove(pet);
            _context.SaveChanges();

            return true;
        }

    }
}