using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces.Repositories;
using ChuteCampeao.Domain.Interfaces.Services;
using ChuteCampeao.Infra.Data.Repositories;
using ChuteCampeao.Services.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.StartUp
{
    public static class Bootstraper
    {
        public static void Register(Container container)
        {
            container.Register<Campeonato>(Lifestyle.Scoped);
            container.Register<Estadio>(Lifestyle.Scoped);
            container.Register<Partida>(Lifestyle.Scoped);
            container.Register<Rodada>(Lifestyle.Scoped);
            container.Register<Time>(Lifestyle.Scoped);

            container.Register<ICampeonatoService, CampeonatoService>(Lifestyle.Scoped);
            container.Register<IEstadioService, EstadioService>(Lifestyle.Scoped);
            container.Register<IPartidaService, PartidaService>(Lifestyle.Scoped);
            container.Register<IRodadaService, RodadaService>(Lifestyle.Scoped);
            container.Register<ITimeService, TimeService>(Lifestyle.Scoped);

            container.Register<ICampeonatoRep, CampeonatoRep>(Lifestyle.Scoped);
            container.Register<IEstadioRep, EstadioRep>(Lifestyle.Scoped);
            container.Register<IPartidaRep, PartidaRep>(Lifestyle.Scoped);
            container.Register<IRodadaRep, RodadaRep>(Lifestyle.Scoped);
            container.Register<ITimeRep, TimeRep>(Lifestyle.Scoped);

        }
    }
}
