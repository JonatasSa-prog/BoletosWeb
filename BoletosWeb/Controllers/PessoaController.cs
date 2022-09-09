using BoletosWeb.Helper;
using BoletosWeb.Models;
using BoletosWeb.Services;
using BoletosWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Controllers
{
    public class PessoaController : Controller
    {
        private readonly PessoaService _PessoaService;
        private readonly TelefoneService _TelefoneService;
        private readonly Session _session;

        public PessoaController(PessoaService pessoaService, Session session, TelefoneService telefoneService)
        {
            _session = session;
            _PessoaService = pessoaService;
            _TelefoneService = telefoneService;
        }

        public IActionResult Index()
        {
            TempData["MensageErro"] = null;
            if (_session.BuscarSessao() != null)
                return View(_PessoaService.GetPessoas(_session.BuscarSessao()));
            return RedirectToAction("Index", "Login");
        }

        public IActionResult Adicionar()
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    if (_session.BuscarSessao() != null)
                    {
                        return View();
                    }
                    return RedirectToAction("Index", "Login");

                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Não foi possivel acessar o sistema, tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult AdicionarPessoa(PessoaViewModel PessoaViewModel)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    PessoaViewModel.Pessoa.Conta = _session.BuscarSessao().Id;                
                    _PessoaService.AdicionarPessoa(PessoaViewModel.Pessoa);
                    PessoaViewModel.Pessoa.AdicionarTelefones(_session.BuscarSessao(), PessoaViewModel.Telefone);
                    _TelefoneService.AdicionarTelefones(PessoaViewModel.Pessoa.Telefones, PessoaViewModel.Pessoa);
                    return RedirectToAction("Index", "Pessoa");
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Detalhe do erro: {ex.Message}";
                return RedirectToAction("Adicionar");
            }
        }

        public IActionResult Editar(int id)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    var pessoa = _PessoaService.GetPessoaById(_session.BuscarSessao(), id);
                    if (pessoa != null)
                        return View(pessoa);
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Não foi possivel acessar o sistema, tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult EditarPessoa(Pessoa pessoa)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    pessoa.Conta = _session.BuscarSessao().Id;
                    _PessoaService.AtualizarPessoa(pessoa);
                    return RedirectToAction("Index", "Pessoa");
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Detalhe do erro: {ex.Message}";
                return RedirectToAction("Adicionar");
            }
        }
    }
}
