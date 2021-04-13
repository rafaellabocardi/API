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
    public class PetController : ControllerBase
    {
        private readonly ILogger<PetController> _logger;
        private readonly DataContext _context;

        public PetController(ILogger<PetController> logger,DataContext context)
        {
            _logger = logger;            
            _context = context;
        }

        [HttpGet]
        public List<Pet> Get()
        {
            PetService petService = new PetService(_context);
            List<Pet> pet = petService.RetornarDados();
            return pet;
        }

        [HttpPost]
        public Pet Post(Pet pet)
        {
            PetService petService = new PetService(_context);
            pet = petService.InserirDados(pet);
            return pet;
        }

        [HttpPut]
        public Pet Put(Pet pet)
        {
            PetService petService = new PetService(_context);
            pet = petService.AlterarDados(pet);
            return pet;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            PetService petService = new PetService(_context);
            bool retorno = petService.DeletarDados(id);
            return retorno;
        }
        
            
    }
}

