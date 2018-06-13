using ChuteCampeao.Domain.Entites;
using ChuteCampeao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCampeao.Infra.Data.Repositories
{
    public class RepTime : RepBase<Time>, IRepTime
    {
        public Time BuscarPorNomeConhecido(string nome)
        {
            return Db.Times.Where(t => t.NomeConhecido == nome).FirstOrDefault();
        }
    }
}
