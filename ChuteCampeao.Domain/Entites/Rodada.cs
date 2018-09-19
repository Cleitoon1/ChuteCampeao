using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Rodada : EntityBase
    {
        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int Situacao { get; set; }

        public virtual Campeonato Campeonato { get; set; }

        public int CampeonatoId { get; set; }

        public ICollection<Partida> Partidas { get; set; }
    }
}