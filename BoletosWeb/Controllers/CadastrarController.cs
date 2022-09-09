using BoletosWeb.Models;
using BoletosWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Controllers
{
    public class CadastrarController : Controller
    {
        private readonly ContaService _ContaService;
        public CadastrarController(ContaService contaRepository)
        {
            _ContaService = contaRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Conta conta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!_ContaService.VerificarEmail(conta))
                    {
                        _ContaService.Adicionar(conta);
                    }
                    TempData["MensageErro"] = $"E-mail já cadastrado. Tente novamente!";
                }

                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Não foi possivel se cadastrar no sistema, tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
