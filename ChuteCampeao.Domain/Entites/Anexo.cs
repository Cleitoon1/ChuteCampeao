using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Domain.Entites
{
    public class Anexo : EntityBase
    {
        public string Tipo { get; set; }

        public string EntidadeAlvo { get; set; }        

        public string Arquivo { get; set; }

    }
}
