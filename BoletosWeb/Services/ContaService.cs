using BoletosWeb.Data;
using BoletosWeb.Interface;
using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Service
{
    public class ContaService : IContaService
    {
        private readonly BoletosWebContext _context;
        public ContaService(BoletosWebContext context)
        {
            _context = context;
        }
        public Conta Adicionar(Conta conta)
        {
            _context.Conta.Add(conta);
            _context.SaveChanges();
            return conta;
        }

        public bool VerificarEmail(Conta conta)
        {
            return _context.Conta.Where(p => p.Email.ToUpper().Equals(conta.Email)).Any();
        }

    }
}
