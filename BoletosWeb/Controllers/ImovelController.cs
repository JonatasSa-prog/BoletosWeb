using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BoletosWeb.Data;
using BoletosWeb.Models;
using BoletosWeb.Services;
using BoletosWeb.Helper;

namespace BoletosWeb.Controllers
{
    public class ImovelController : Controller
    {
        private readonly ImovelService _ImovelService;
        private readonly PessoaService _PessoaService;
        private readonly Session _session;

        public ImovelController(ImovelService imovelService,PessoaService pessoaService, Session session)
        {
            _ImovelService = imovelService;
            _session = session;
            _PessoaService = pessoaService;
        }

        public IActionResult Index()
        {
            TempData["MensageErro"] = null;
            if (_session.BuscarSessao() != null)
                return View(_ImovelService.GetImoveis(_session.BuscarSessao()));
            return RedirectToAction("Index", "Login");
        }
        public IActionResult Adicionar()
        {
            try
            {
                if(_session.BuscarSessao() != null)
                {
                    if (_session.BuscarSessao() != null) {
                        ViewData.Add("DadosPessoa", _PessoaService.GetPessoas(_session.BuscarSessao()));
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
        public IActionResult AdicionarImovel(Imovel imovel)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    imovel.VerificarImovel();
                    imovel.Conta = _session.BuscarSessao().Id;
                    imovel.Proprietario = _PessoaService.GetPessoaById(_session.BuscarSessao(), imovel.IdProprietario);
                    imovel.Morador = _PessoaService.GetPessoaById(_session.BuscarSessao(), imovel.IdMorador);
                    _ImovelService.AdicionarImovel(imovel);
                    return RedirectToAction("Index", "Imovel");
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
                    if (_session.BuscarSessao() != null)
                    {
                        ViewData.Add("DadosPessoa", _PessoaService.GetPessoas(_session.BuscarSessao()));
                        var imovel = _ImovelService.GetImoveilById(_session.BuscarSessao(), id);
                        if(imovel != null)
                            return View(imovel);
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
        public IActionResult EditarImovel(Imovel imovel)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    imovel.VerificarImovel();
                    imovel.Conta = _session.BuscarSessao().Id;
                    imovel.Proprietario = _PessoaService.GetPessoaById(_session.BuscarSessao(), imovel.IdProprietario);
                    imovel.Morador = _PessoaService.GetPessoaById(_session.BuscarSessao(), imovel.IdMorador);
                    _ImovelService.AtualizarImovel(imovel);
                    return RedirectToAction("Index", "Imovel");
                }
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensageErro"] = $"Detalhe do erro: {ex.Message}";
                return RedirectToAction("Adicionar");
            }
        }

        public IActionResult Remover(int id)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    if (_session.BuscarSessao() != null)
                    {
                        ViewData.Add("DadosPessoa", _PessoaService.GetPessoas(_session.BuscarSessao()));
                        var imovel = _ImovelService.GetImoveilById(_session.BuscarSessao(), id);
                        if (imovel != null)
                            return View(imovel);
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
        public IActionResult RemoverImovel(Imovel imovel)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    _ImovelService.RemoverImovel(imovel);
                    return RedirectToAction("Index", "Imovel");
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
