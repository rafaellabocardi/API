using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonoPetController : ControllerBase
    {
        private readonly ILogger<DonoPetController> _logger;
        private readonly DataContext _context;

        public DonoPetController(ILogger<DonoPetController> logger,DataContext context)
        {
            _logger = logger;            
            _context = context;
        }
        
        [HttpGet]
        public List<DonoPet> Get()
        {
            DonoPetService petService = new DonoPetService(_context);
            List<DonoPet> donoPet = petService.RetornarDados();
            return donoPet;
        }

        [HttpPost]
        public DonoPet Post(DonoPet donoPet)
        {
            DonoPetService donoPetService = new DonoPetService(_context);
            donoPet = donoPetService.InserirDados(donoPet);
            return donoPet;
        }

        [HttpPut]
        public DonoPet Put(DonoPet donoPet)
        {
            DonoPetService donoPetService = new DonoPetService(_context);
            donoPet = donoPetService.AlterarDados(donoPet);
            return donoPet;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            DonoPetService donoPetService = new DonoPetService(_context);
            bool retorno = donoPetService.DeletarDados(id);
            return retorno;
        }
    }
}
