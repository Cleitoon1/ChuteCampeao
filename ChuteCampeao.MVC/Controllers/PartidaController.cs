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
    public class PartidaController : Controller
    {
        private readonly IPartidaService _partidaService;

        public PartidaController(IPartidaService partidaService)
        {
            this._partidaService = partidaService;
        }

        public ActionResult Index()
        {
            var data = Mapper.Map<IEnumerable<Partida>, IEnumerable<PartidaVM>>(_partidaService.GetAll());
            return View(data);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(PartidaVM model)
        {
            _partidaService.Add(Mapper.Map<Partida>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            return View(Mapper.Map<PartidaVM>(_partidaService.GetById(id)));
        }

        public ActionResult Editar(int id)
        {
            PartidaVM data = Mapper.Map<PartidaVM>(_partidaService.GetById(id));
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(PartidaVM model)
        {
            _partidaService.Update(Mapper.Map<Partida>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int id)
        {
            _partidaService.RemoveById(id);
            return RedirectToAction("Index");
        }
    }
}