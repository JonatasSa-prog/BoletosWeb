using BoletosWeb.Data;
using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Services
{
    public class TelefoneService
    {
        private readonly BoletosWebContext _context;
        public TelefoneService(BoletosWebContext context)
        {
            _context = context;
        }

        public List<Telefone> GetTelefones(Conta conta)
        {
            return _context.Telefone.Where(p => p.Conta == conta.Id).ToList();
        }

        public Telefone GetPessoaById(Conta conta, int id)
        {
            return GetTelefones(conta).Where(p => p.Id == id).FirstOrDefault();
        }

        public void AdicionarTelefone(Telefone telefone)
        {
            try
            {
                _context.Telefone.Add(telefone);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao adicionar o Telefone. Detalhes do erro: {ex.Message}");
            }

        }

        public void AdicionarTelefones(List<Telefone> telefones, Pessoa pessoa)
        {
            try
            {
                foreach (var telefone in telefones)
                {
                    telefone.Pessoa = pessoa;
                    AdicionarTelefone(telefone);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao adicionar o Telefone. Detalhes do erro: {ex.Message}");
            }

        }

        public void AtualizarTelefone(Telefone telefone)
        {
            try
            {
                _context.Telefone.Update(telefone);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao atualizar o Telefone. Detalhes do erro: {ex.Message}");
            }
        }
    }
}
