using BoletosWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessionConta = HttpContext.Session.GetString("sessionLogado");

            if(string.IsNullOrEmpty(sessionConta))
                return null;

            Conta conta = JsonConvert.DeserializeObject<Conta>(sessionConta);


            return View(conta);
        }


    }
}
