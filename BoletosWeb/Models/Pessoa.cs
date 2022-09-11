using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int Conta { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Telefones")]
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
        [Display(Name = "Tipo Pessoa")]
        public bool TipoPessoa { get; set; }
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }
        public virtual Endereco Endereco { get; set; }

        public string TipoPessoaToString()
        {
            if (this.TipoPessoa == true)
                return "Juridica";
            return "Fisica";
        }

        public string TipoPessoaDocumentoToString()
        {
            if (this.TipoPessoa == true)
                return FormatCNPJ(this.CNPJ);
            return FormatCPF(this.CPF);
        }
        internal string FormatCNPJ(string CNPJ)
        {
            return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        internal string FormatCPF(string CPF)
        {
            return Convert.ToUInt64(CPF).ToString(@"000\.000\.000\-00");
        }

        internal void AdicionarTelefones(Conta conta,string Telefone)
        {
            this.Telefones.Add(new Telefone()
            {
                DDD = Telefone.Substring(0, 2),
                Numero = Telefone.Substring(2, 9),
                Conta = conta.Id
            });
        }
    }
}
