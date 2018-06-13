using ChuteCampeao.Domain.Entites;

namespace ChuteCampeao.Domain.Interfaces
{
    public interface IRepTime : IRepBase<Time>
    {
        Time BuscarPorNomeConhecido(string nome);
    }
}
