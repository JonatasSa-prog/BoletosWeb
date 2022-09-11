using BoletosWeb.Data;
using BoletosWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Services
{
    public class EnderecoService
    {
        private readonly BoletosWebContext _context;
        public EnderecoService(BoletosWebContext context)
        {
            _context = context;
        }
        public List<Endereco> GetEnderecos(Conta conta)
        {
            return _context.Endereco.Include(p => p.Pessoa).Where(p => p.Conta == conta.Id).ToList();
        }
    }
}
