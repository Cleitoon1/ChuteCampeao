using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Campeonato
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int Status { get; set; }

        public ICollection<Rodada> Rodadas { get; set; }

        public ICollection<Time> Times { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}