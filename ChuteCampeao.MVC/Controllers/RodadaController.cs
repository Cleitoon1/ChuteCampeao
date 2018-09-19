using AutoMapper;
using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces.Services;
using ChuteCampeao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.Controllers
{
    public class RodadaController : Controller
    {
        private readonly IRodadaService _rodadaService;

        public RodadaController(IRodadaService rodadaService)
        {
            this._rodadaService = rodadaService;
        }

        public ActionResult Index()
        {
            var data = Mapper.Map<IEnumerable<Rodada>, IEnumerable<RodadaVM>>(_rodadaService.GetAll());
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(RodadaVM model)
        {
            _rodadaService.Add(Mapper.Map<Rodada>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            return View(Mapper.Map<RodadaVM>(_rodadaService.GetById(id)));
        }

        public ActionResult Editar(int id)
        {
            RodadaVM data = Mapper.Map<RodadaVM>(_rodadaService.GetById(id));
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(RodadaVM model)
        {
            _rodadaService.Update(Mapper.Map<Rodada>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int id)
        {
            _rodadaService.RemoveById(id);
            return RedirectToAction("Index");
        }
    }
}