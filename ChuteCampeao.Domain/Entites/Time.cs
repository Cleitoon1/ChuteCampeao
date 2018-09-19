using System;
using System.Collections;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Time : EntityBase
    {
        public string NomeCompleto { get; set; }

        public string NomeAbreviado { get; set; }

        public string Apelido { get; set; }

        public DateTime DataFundacao { get; set; }

        public Estadio Estadio { get; set; }

        public int EstadioId { get; set; }

        public ICollection<Partida> PartidasVisitante { get; set; }

        public ICollection<Partida> PartidasLocal { get; set; }

        public ICollection<Campeonato> Campeonatos { get; set; }
    }
}
