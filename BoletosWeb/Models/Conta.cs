using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Models
{
    public class Conta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; }
        public string Nome { get; set; }

        public bool SenhaValida(Conta conta)
        {
            return conta.Senha == Senha;
        }
    }
}
