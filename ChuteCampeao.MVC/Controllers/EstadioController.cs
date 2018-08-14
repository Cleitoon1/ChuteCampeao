using AutoMapper;
using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces.Services;
using ChuteCampeao.Infra.Data.Repositories;
using ChuteCampeao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.Controllers
{
    public class EstadioController : Controller
    {
        private readonly IEstadioService _estadioService;

        public EstadioController(IEstadioService estadioService)
        {
            this._estadioService = estadioService;
        }

        public ActionResult Index()
        {
            var estadioVM = Mapper.Map<IEnumerable<Estadio>, IEnumerable<EstadioVM>>(_estadioService.GetAll());
            return View(estadioVM);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(EstadioVM model)
        {
            _estadioService.Add(Mapper.Map<Estadio>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            return View(Mapper.Map<EstadioVM>(_estadioService.GetById(id)));
        }

        public ActionResult Editar(int id)
        {
            return View(Mapper.Map<EstadioVM>(_estadioService.GetById(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(EstadioVM model)
        {
            _estadioService.Update(Mapper.Map<Estadio>(model));
            return RedirectToAction("Index"); 
        }

        [HttpPost]
        
        public ActionResult Deletar(int id)
        {
            _estadioService.RemoveById(id);
            return RedirectToAction("Index");
        }

    }
}