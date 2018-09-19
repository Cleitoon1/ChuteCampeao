using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces.Repositories;
using ChuteCampeao.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Services.Services
{
    public class EstadioService : BaseService<Estadio>, IEstadioService
    {
        private readonly IEstadioRep _estadioRep;

        public EstadioService(IEstadioRep estadioRep) : base(estadioRep)
        {
            this._estadioRep = estadioRep;
        }

        public IEnumerable<Estadio> BuscarAtivos()
        {
            return _estadioRep.GetAll().Where(x => x.Status == true).ToList();
        }
    }
}
