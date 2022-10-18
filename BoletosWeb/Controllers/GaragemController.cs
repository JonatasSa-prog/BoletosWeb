using BoletosWeb.Helper;
using BoletosWeb.Models;
using BoletosWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletosWeb.Controllers
{
    public class GaragemController : Controller
    {
        private readonly GaragemService _GaragemService;
        private readonly ImovelService _ImovelService;
        private readonly Session _session;

        public GaragemController(GaragemService garagemService, ImovelService imovelService, Session session)
        {
            _GaragemService = garagemService;
            _ImovelService = imovelService;
            _session = session;
        }
        public IActionResult Index()
        {
            TempData["MensageErro"] = null;
            if (_session.BuscarSessao() != null)
                return View(_GaragemService.GetGaragens(_session.BuscarSessao()));
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
                        ViewData.Add("DadosImoveis", _ImovelService.GetImoveis(_session.BuscarSessao()));
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
        public IActionResult AdicionarGaragem(Garagem garagem)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    garagem.Conta = _session.BuscarSessao().Id;
                    garagem.Imovel = _ImovelService.GetImoveilById(_session.BuscarSessao(), garagem.IdImovel);
                    _GaragemService.AdicionarGaragem(garagem);
                    return RedirectToAction("Index", "Garagem");
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
                        ViewData.Add("DadosImoveis", _ImovelService.GetImoveis(_session.BuscarSessao()));
                        var garagem = _GaragemService.GetgaragemById(_session.BuscarSessao(), id);
                        if (garagem != null)
                            return View(garagem);
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
        public IActionResult EditarGaragem(Garagem garagem)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    garagem.Conta = _session.BuscarSessao().Id;
                    garagem.Imovel = _ImovelService.GetImoveilById(_session.BuscarSessao(), garagem.IdImovel);
                    _GaragemService.AtualizarGaragem(garagem);
                    return RedirectToAction("Index", "Garagem");
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
                        ViewData.Add("DadosImoveis", _ImovelService.GetImoveis(_session.BuscarSessao()));
                        var garagem = _GaragemService.GetgaragemById(_session.BuscarSessao(), id);
                        if (garagem != null)
                            return View(garagem);
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
        public IActionResult RemoverGaragem(Garagem garagem)
        {
            try
            {
                if (_session.BuscarSessao() != null)
                {
                    _GaragemService.RemoverGaragem(garagem);
                    return RedirectToAction("Index", "Garagem");
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
