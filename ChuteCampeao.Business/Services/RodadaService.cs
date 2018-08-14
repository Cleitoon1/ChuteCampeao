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
    public class RodadaService : BaseService<Rodada>, IRodadaService
    {
        private readonly IRodadaRep _rodadaRep;

        public RodadaService(IRodadaRep rodadaRep) : base(rodadaRep)
        {
            this._rodadaRep = rodadaRep;
        }
    }
}
