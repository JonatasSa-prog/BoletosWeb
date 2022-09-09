using BoletosWeb.Data;
using BoletosWeb.Helper;
using BoletosWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Services
{
    public class ImovelService
    {
        private readonly BoletosWebContext _context;
        public ImovelService(BoletosWebContext context)
        {
            _context = context;
        }
        public List<Imovel> GetImoveis(Conta conta)
        {
            return _context.Imovel.Include(p => p.Proprietario).Include(p => p.Morador).Where(p => p.Conta == conta.Id).ToList();
        }

        public Imovel GetImoveilById(Conta conta, int idImovel)
        {
            return GetImoveis(conta).Where(p => p.Id == idImovel).FirstOrDefault();
        }

        public void AdicionarImovel(Imovel imovel)
        {
            try
            {
                _context.Imovel.Add(imovel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao adicionar o Imovel. Detalhes do erro: {ex.Message}");
            }

        }

        public void AtualizarImovel(Imovel imovel)
        {
            try
            {
                _context.Imovel.Update(imovel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao atualizar o Imovel. Detalhes do erro: {ex.Message}");
            }
        }

        public void RemoverImovel(Imovel imovel)
        {
            try
            {
                _context.Imovel.Remove(imovel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ao remover o Imovel. Detalhes do erro: {ex.Message}");
            };
        }
    }
}

