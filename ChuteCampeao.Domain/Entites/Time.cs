using System;
using System.Collections;

namespace ChuteCampeao.Domain.Entites
{
    public class Time
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string NomeConhecido { get; set; }

        public string Apelido { get; set; }

        public DateTime DataFundacao { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}
