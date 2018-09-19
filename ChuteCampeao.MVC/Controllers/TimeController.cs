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
    public class TimeController : Controller
    {
        private readonly ITimeService _timeService;
        private readonly IEstadioService _estadioService;

        public TimeController(ITimeService timeService, IEstadioService estadioService)
        {
            this._timeService = timeService;
            this._estadioService = estadioService;
        }

        public ActionResult Index()
        {
            var data = Mapper.Map<IEnumerable<Time>, IEnumerable<TimeVM>>(_timeService.GetAll());
            return View(data);
        }

        public ActionResult Criar()
        {
            TimeVM data = new TimeVM() {
                ListaEstadios = _estadioService.BuscarAtivos().Select(x => new SelectListItem()
                {
                    Value = x.Id.ToString(),
                    Text = string.IsNullOrEmpty(x.Apelido) || string.IsNullOrWhiteSpace(x.Apelido) ? x.Nome : x.Apelido
                }),
                LstStatus = Utils.ListarStatus()
            };
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(TimeVM model)
        {
            _timeService.Add(Mapper.Map<Time>(model));
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            return View(Mapper.Map<TimeVM>(_timeService.GetById(id)));
        }

        public ActionResult Editar(int id)
        {
            TimeVM data = Mapper.Map<TimeVM>(_timeService.GetById(id));
            data.ListaEstadios = _estadioService.BuscarAtivos().Select(x => new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = string.IsNullOrEmpty(x.Apelido) || string.IsNullOrWhiteSpace(x.Apelido) ? x.Nome : x.Apelido
            });
            data.LstStatus = Utils.ListarStatus();
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(TimeVM model)
        {
            _timeService.Update(Mapper.Map<Time>(model));
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public void Excluir(int id)
        {
            _timeService.RemoveById(id);
        }
    }
}