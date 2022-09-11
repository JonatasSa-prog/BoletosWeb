using System.ComponentModel.DataAnnotations.Schema;

namespace BoletosWeb.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public int Conta { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public UF IdUF { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public bool Ativo { get; set; }
    }
}