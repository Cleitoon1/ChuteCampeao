using ChuteCampeao.Domain.Entites;
using System.Collections.Generic;

namespace ChuteCampeao.Domain.Interfaces.Services
{
    public interface ITimeService : IBaseService<Time>
    {
        IEnumerable<Time> BuscarAtivos();
    }
}
