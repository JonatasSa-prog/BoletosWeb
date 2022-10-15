using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Models
{
    public class Garagem
    {
        public int Id { get; set; }
        public int Conta { get; set; }
        [Display(Name = "Código Garagem")]
        public string codGaragem { get; set; }
        [Display(Name = "Imovel")]
        public virtual Imovel Imovel { get; set; }
        [NotMapped]
        public int IdImovel { get; set; }
    }
}
