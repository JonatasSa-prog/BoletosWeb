using BoletosWeb.Models.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Models
{
    public class Financeiro
    {
        public int Id { get; set; }
        public int IdConta { get; set; }
        public int IdImovel { get; set; }
        public int IdPessoaMorador { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataReferencia { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
        public double ValorPago { get; set; }   
        public double ValorExtra { get; set; }
        public double ValorDevido { get; set; }
        public TipoFinanceiro Tipo { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
