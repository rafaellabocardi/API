using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Services
{
    public class AtendimentoService
    {
        //public Double CalculaAtendimento(Double TotalValorAtend, int numAtendimentos)
        //{
          //Double ValorAtendimento = 50;
          //TotalValorAtend = (ValorAtendimento*numAtendimentos);
          //return TotalValorAtend;
        //} 

        private readonly DataContext _context;
        public AtendimentoService(DataContext context)
        {
            _context = context;
        }

        public List<Atendimento> RetornarDados()
        {
             List<Atendimento> pets = _context.Atendimentos.ToList();
             return pets;
        }


        public Atendimento InserirDados(Atendimento atendimento)
        {
            _context.Atendimentos.Add(atendimento);
            _context.SaveChanges();

            return atendimento;
        }

        public Atendimento AlterarDados(Atendimento atendimento)
        {
            _context.Atendimentos.Update(atendimento);
            _context.SaveChanges();

            return atendimento;
        }

        public bool DeletarDados(int id)
        {
            Atendimento atendimento = _context.Atendimentos.Where(x=>x.AtendimentoId==id).FirstOrDefault();
            if(atendimento==null)
            {
                return false;
            }
            _context.Atendimentos.Remove(atendimento);
            _context.SaveChanges();

            return true;
        }
    }
}