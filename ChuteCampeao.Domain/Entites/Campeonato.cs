using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Campeonato : EntityBase
    {
        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int Situacao { get; set; }

        public ICollection<Rodada> Rodadas { get; set; }

        public ICollection<Time> Times { get; set; }

    }
}