using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Interface
{
    public interface IContaService
    {
        public Conta Adicionar(Conta conta);
        public bool VerificarEmail(Conta conta);

    }
}
