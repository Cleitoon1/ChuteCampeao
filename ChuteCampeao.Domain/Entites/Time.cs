using System;
using System.Collections;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Time
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string NomeConhecido { get; set; }

        public string Apelido { get; set; }

        public DateTime DataFundacao { get; set; }

        public Estadio Estadio { get; set; }

        public int EstadioId { get; set; }

        public ICollection<Partida> PartidasVisitante { get; set; }

        public ICollection<Partida> PartidasLocal { get; set; }

        public ICollection<Campeonato> Campeonatos { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}
