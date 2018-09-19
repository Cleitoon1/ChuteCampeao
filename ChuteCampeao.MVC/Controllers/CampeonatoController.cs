using AutoMapper;
using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces.Services;
using ChuteCampeao.MVC.Helpers;
using ChuteCampeao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.Controllers
{
    public class CampeonatoController : Controller
    {
        private readonly ICampeonatoService _campeonatoService;

        public CampeonatoController(ICampeonatoService campeonatoService)
        {
            this._campeonatoService = campeonatoService;
        }

        public ActionResult Index()
        {
            var data = Mapper.Map<IEnumerable<Campeonato>, IEnumerable<CampeonatoVM>>(_campeonatoService.GetAll());
            return View(data);
        }

        public ActionResult Criar()
        {
            CampeonatoVM campeonatoVM = new CampeonatoVM()
            {
                ListaStatus = Utils.ListarStatus()
            };
            return View(campeonatoVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(CampeonatoVM model)
        {
            _campeonatoService.Add(Mapper.Map<Campeonato>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            return View(Mapper.Map<CampeonatoVM>(_campeonatoService.GetById(id)));
        }

        public ActionResult Editar(int id)
        {
            CampeonatoVM data = Mapper.Map<CampeonatoVM>(_campeonatoService.GetById(id));
            data.ListaStatus = Utils.ListarStatus();
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(CampeonatoVM model)
        {
            _campeonatoService.Update(Mapper.Map<Campeonato>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Deletar(int id)
        {
            _campeonatoService.RemoveById(id);
            return RedirectToAction("Index");
        }
    }
}