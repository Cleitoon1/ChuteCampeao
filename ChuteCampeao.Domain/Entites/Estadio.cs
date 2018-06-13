using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Estadio
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Partida> Partidas { get; set; }

        public ICollection<Time> Times { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}