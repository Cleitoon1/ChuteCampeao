using System;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Entites
{
    public class Rodada
    {
        public int Id { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int Status { get; set; }

        public virtual Campeonato Campeonato { get; set; }

        public int CampeonatoId { get; set; }

        public ICollection<Partida> Partidas { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}