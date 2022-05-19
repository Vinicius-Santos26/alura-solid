
namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ICommand<T>
    {
        void Incluir(T entity);
        void Alterar(T entity);
        void Excluir(T entity);
    }
}
