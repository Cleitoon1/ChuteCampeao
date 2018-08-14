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
    public class PartidaService : BaseService<Partida>, IPartidaService
    {
        private readonly IPartidaRep _partidaRep;

        public PartidaService(IPartidaRep partidaRep) : base(partidaRep)
        {
            this._partidaRep = partidaRep;
        }
    }
}
