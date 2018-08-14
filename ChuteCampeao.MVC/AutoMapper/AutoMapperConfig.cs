using AutoMapper;
using ChuteCampeao.Domain.Entites;
using ChuteCampeao.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuteCampeao.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x => {
                x.CreateMap<EstadioVM, Estadio>();
                x.CreateMap<Estadio, EstadioVM>();

                x.CreateMap<CampeonatoVM, Campeonato>();
                x.CreateMap<Campeonato, CampeonatoVM>();

                x.CreateMap<PartidaVM, Partida>();
                x.CreateMap<Partida, PartidaVM>();

                x.CreateMap<TimeVM, Time>();
                x.CreateMap<Time, TimeVM>();

                x.CreateMap<RodadaVM, Rodada>();
                x.CreateMap<Rodada, RodadaVM>();
            });
           
        }
    }
}