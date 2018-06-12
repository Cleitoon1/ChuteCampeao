using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Domain.Entites
{
    public class Partida
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public int PlacarTimeLocal { get; set; }

        public int PlacarTimeVisitante { get; set; }

        public virtual Time TimeLocal { get; set; }
        public int TimeLocalId { get; set; }

        public virtual Time TimeVisitante { get; set; }
        public int TimeVisitanteId { get; set; }
        

        public virtual Estadio Estadio { get; set; }
        public int EstadioId { get; set; }

        public virtual Rodada Rodada { get; set; }
        public int RodadaId { get; set; }
        
        public DateTime DataCadastro { get; set; }

        public int Status { get; set; }

        public bool Ativo { get; set; }
    }
}