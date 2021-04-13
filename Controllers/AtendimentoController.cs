using System.Collections.Generic;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class AtendimentoController : ControllerBase
    {
        private readonly ILogger<AtendimentoController> _logger;
        private readonly DataContext _context;

        public AtendimentoController(ILogger<AtendimentoController> logger,DataContext context)
        {
            _logger = logger;            
            _context = context;
        }

        [HttpGet]
        public List<Atendimento> Get()
        {
            AtendimentoService atendimentoService = new AtendimentoService(_context);
            List<Atendimento> atendimento = atendimentoService.RetornarDados();
            return atendimento;
        }

        [HttpPost]
        public Atendimento Post(Atendimento atendimento)
        {
            AtendimentoService atendimentoService = new AtendimentoService(_context);
            atendimento = atendimentoService.InserirDados(atendimento);
            return atendimento;
        }

        [HttpPut]
        public Atendimento Put(Atendimento atendimento)
        {
            AtendimentoService atendimentoService = new AtendimentoService(_context);
            atendimento = atendimentoService.AlterarDados(atendimento);
            return atendimento;
        }


        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            AtendimentoService atendimentoService = new AtendimentoService(_context);
            bool retorno = atendimentoService.DeletarDados(id);
            return retorno;
        }
    }
}