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

            container.Register<ICampeonatoService, CampeonatoService>(Lifestyle.Singleton);
            container.Register<IEstadioService, EstadioService>(Lifestyle.Singleton);
            container.Register<IPartidaService, PartidaService>(Lifestyle.Singleton);
            container.Register<IRodadaService, RodadaService>(Lifestyle.Singleton);
            container.Register<ITimeService, TimeService>(Lifestyle.Singleton);

            container.Register<ICampeonatoRep, CampeonatoRep>(Lifestyle.Singleton);
            container.Register<IEstadioRep, EstadioRep>(Lifestyle.Singleton);
            container.Register<IPartidaRep, PartidaRep>(Lifestyle.Singleton);
            container.Register<IRodadaRep, RodadaRep>(Lifestyle.Singleton);
            container.Register<ITimeRep, TimeRep>(Lifestyle.Singleton);

        }
    }
}
