using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Helper
{
    interface ISession
    {
        void CriarSessao(Conta conta);
        void EncerrarSessao();
        Conta BuscarSessao();
    }
}
