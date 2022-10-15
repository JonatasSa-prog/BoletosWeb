using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public int Conta { get; set; }
        [Display(Name = "Código Imovel")]
        public string codImovel { get; set; }   
        [Display(Name = "Proprietário")]
        public virtual Pessoa Proprietario { get; set; }
        [Display(Name = "Morador")]
        public virtual Pessoa Morador { get; set; }
        [Display(Name = "Dimensão")]
        public double dimensao { get; set; }
        [Display(Name = "Garagens")]
        public int numGaragem { get; set; }
        [Display(Name = "Valor")]
        public double valor { get; set; }
        [Display(Name = "Valor Extra")]
        public double vrExtra { get; set; }
        [Display(Name = "Valor Devido")]
        public double vrDevido { get; set; }
        [NotMapped]
        public int IdProprietario { get; set; }
        [NotMapped]
        public int IdMorador { get; set; }

        public void VerificarImovel()
        {
            if (string.IsNullOrWhiteSpace(this.codImovel))
                throw new Exception("Código do Imóvel não pode ser vazio.");
            if (this.IdProprietario == 0)
                throw new Exception("Proprietário deve ser selecionado");
            if (this.IdMorador == 0)
                throw new Exception("Morador deve ser selecionado");
            if (string.IsNullOrWhiteSpace(this.dimensao.ToString()))
                throw new Exception("Dimensão não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(this.numGaragem.ToString()))
                throw new Exception("Número de garagens não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(this.valor.ToString()))
                throw new Exception("Valor não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(this.vrExtra.ToString()))
                throw new Exception("Valor Extra não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(this.vrDevido.ToString()))
                throw new Exception("Valor Devido não pode ser vazio.");

        }

    }
}
