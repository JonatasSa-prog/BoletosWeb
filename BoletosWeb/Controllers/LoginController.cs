using BoletosWeb.Helper;
using BoletosWeb.Interface;
using BoletosWeb.Models;
using BoletosWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService  _LoginService;
        private readonly Session _session;
        public LoginController(LoginService loginService, Session session)
        {
            _session = session;
            _LoginService = loginService;
        }
        public IActionResult Index()
        {
            TempData["MensageErro"] = null;
            if (_session.BuscarSessao() != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public IActionResult Login(Conta conta)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Conta = _LoginService.BuscarPorEmail(conta.Email);
                    if(Conta != null)
                    {
                        if (Conta.SenhaValida(conta))
                        {
                            _session.CriarSessao(Conta);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensageErro"] = $"Senha inválida. Tente novamente!";
                    }
                    TempData["MensageErro"] = $"Usuário e/ou Senha inválido(s). Tente novamente!";
                }

                return View("Index");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Não foi possivel acessar o sistema, tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Sair()
        {
            try
            {
                _session.EncerrarSessao();
                return RedirectToAction("Index", "Login");

            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Não foi possivel acessar o sistema, tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
