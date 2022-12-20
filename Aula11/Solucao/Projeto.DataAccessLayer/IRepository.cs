namespace Projeto.DataAccessLayer
{
    public interface IRepository<T>
    {
        void CriarNovo(T objeto);
        T ObterPorId(int id);
        T Atualizar(int id, T objeto);
        void Apagar(int id);
    }
}