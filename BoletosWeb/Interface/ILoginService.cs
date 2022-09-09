using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Interface
{
    interface ILoginService
    {
        public Conta BuscarPorEmail(string conta);
    }
}
