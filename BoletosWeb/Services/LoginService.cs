using BoletosWeb.Data;
using BoletosWeb.Interface;
using BoletosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Service
{
    public class LoginService : ILoginService
    {
        private readonly BoletosWebContext _context;
        public LoginService(BoletosWebContext context)
        {
            _context = context;
        }
        public Conta BuscarPorEmail(string email)
        {
           return _context.Conta.Where(p => p.Email.ToUpper().Equals(email.ToUpper())).FirstOrDefault();
        }
    }
}
