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
    public class TimeService : BaseService<Time>, ITimeService
    {
        private readonly ITimeRep _timeRep;

        public TimeService(ITimeRep timeRep) : base(timeRep)
        {
            this._timeRep = timeRep;
        }
    }
}
