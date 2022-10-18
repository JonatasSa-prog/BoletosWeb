using BoletosWeb.Data;
using BoletosWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Services
{
    public class GaragemService
    {
        private readonly BoletosWebContext _context;
        public GaragemService(BoletosWebContext context)
        {
            _context = context;
        }
        public List<Garagem> GetGaragens(Conta conta)
        {
            return _context.Garagem.Include(p => p.Imovel.Morador).Where(p => p.Conta == conta.Id).ToList();
        }

        public Garagem GetgaragemById(Conta conta, int idGaragem)
        {
            return GetGaragens(conta).Where(p => p.Id == idGaragem).FirstOrDefault();
        }

        public void AdicionarGaragem(Garagem garagem)
        {
            try
            {
                _context.Garagem.Add(garagem);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao adicionar a Garagem. Detalhes do erro: {ex.Message}");
            }

        }
        public void AtualizarGaragem(Garagem garagem)
        {
            try
            {
                _context.Garagem.Update(garagem);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao atualizar o Garagem. Detalhes do erro: {ex.Message}");
            }
        }

        public void RemoverGaragem(Garagem garagem)
        {
            try
            {
                _context.Garagem.Remove(garagem);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao remover o Garagem. Detalhes do erro: {ex.Message}");
            };
        }
    }
}
