using System.Collections.Generic;
using System.Linq;

namespace api.Services
{
    public class DonoPetService
    {
        private readonly DataContext _context;
        public DonoPetService(DataContext context)
        {
            _context = context;
        }

        public List<DonoPet> RetornarDados()
        {
             List<DonoPet> donoPets = _context.DonoPets.ToList();
             return donoPets;
        }

        
        public DonoPet InserirDados(DonoPet donoPet)
        {
            _context.DonoPets.Add(donoPet);
            _context.SaveChanges();

            return donoPet;
        }

        public DonoPet AlterarDados(DonoPet donoPet)
        {
            _context.DonoPets.Update(donoPet);
            _context.SaveChanges();

            return donoPet;
        }

        public bool DeletarDados(int id)
        {
            DonoPet donoPet = _context.DonoPets.Where(x=>x.DonoPetId==id).FirstOrDefault();
            if(donoPet==null)
            {
                return false;
            }
            _context.DonoPets.Remove(donoPet);
            _context.SaveChanges();

            return true;
        }
    }
}