using BoletosWeb.Data;
using BoletosWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Services
{
    public class PessoaService
    {
        private readonly BoletosWebContext _context;
        public PessoaService(BoletosWebContext context)
        {
            _context = context;
        }
        public List<Pessoa> GetPessoas(Conta conta)
        {
            return _context.Pessoa.Where(p => p.Conta == conta.Id).Include(p => p.Telefones).Include(p => p.Endereco).ToList();
        }

        public Pessoa GetPessoaById(Conta conta, int id)
        {
            return GetPessoas(conta).Where(p => p.Id == id).FirstOrDefault();
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            try
            {
                _context.Pessoa.Add(pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao adicionar o Imovel. Detalhes do erro: {ex.Message}");
            }

        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            try
            {
                _context.Pessoa.Update(pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao atualizar o Pessoa. Detalhes do erro: {ex.Message}");
            }
        }

        internal void RemoverPessoa(Pessoa pessoa)
        {
            try
            {
                _context.Pessoa.Remove(pessoa);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao remover o Pessoa. Detalhes do erro: {ex.Message}");
            }
        }
    }
}
