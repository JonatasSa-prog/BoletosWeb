using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletosWeb.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        [NotMapped]
        public int Conta { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }

        public string GetTelefoneString()
        {
            return $"{this.DDD}{this.Numero}";
        }
    }
}