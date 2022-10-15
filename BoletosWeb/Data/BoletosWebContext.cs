using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using BoletosWeb.Models;

namespace BoletosWeb.Data
{
    public class BoletosWebContext : DbContext
    {
        public BoletosWebContext (DbContextOptions<BoletosWebContext> options) : base(options)
        {

        }

        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Imovel> Imovel { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<Garagem> Garagem { get; set; }
    }
}
