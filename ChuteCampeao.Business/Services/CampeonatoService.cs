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
    public class CampeonatoService : BaseService<Campeonato>, ICampeonatoService
    {
        private readonly ICampeonatoRep _campeonatoRep;

        public CampeonatoService(ICampeonatoRep campeonatoRep) : base(campeonatoRep)
        {
            this._campeonatoRep = campeonatoRep;
        }
    }
}
