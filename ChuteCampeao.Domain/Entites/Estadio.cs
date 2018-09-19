using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Estadio : EntityBase
    {
        public string Nome { get; set; }

        public string Apelido { get; set; }

        public DateTime DataInauguracao { get; set; }

        public int Capacidade { get; set; }

        public ICollection<Partida> Partidas { get; set; }

        public ICollection<Time> Times { get; set; }
    }
}