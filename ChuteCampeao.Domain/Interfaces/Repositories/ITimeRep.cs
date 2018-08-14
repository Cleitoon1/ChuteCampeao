using ChuteCampeao.Domain.Entites;

namespace ChuteCampeao.Domain.Interfaces.Repositories
{
    public interface ITimeRep : IBaseRep<Time>
    {
        Time BuscarPorNomeConhecido(string nome);
    }
}
