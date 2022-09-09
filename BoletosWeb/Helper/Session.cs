using BoletosWeb.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Helper
{
    public class Session : ISession
    {
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public Conta BuscarSessao()
        {
            var sessaoConta = _httpContext.HttpContext.Session.GetString("sessionLogado");
            if (string.IsNullOrEmpty(sessaoConta)) 
                return null;
            return JsonConvert.DeserializeObject<Conta>(sessaoConta);

        }

        public void CriarSessao(Conta conta)
        {
            var contaString = JsonConvert.SerializeObject(conta);
            _httpContext.HttpContext.Session.SetString("sessionLogado", contaString);
        }

        public void EncerrarSessao()
        {
            _httpContext.HttpContext.Session.Remove("sessionLogado");
        }
    }
}
