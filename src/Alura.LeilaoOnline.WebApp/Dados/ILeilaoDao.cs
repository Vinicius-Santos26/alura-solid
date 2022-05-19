using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao: IQuery<Leilao>, ICommand<Leilao>
    {
    }
}
