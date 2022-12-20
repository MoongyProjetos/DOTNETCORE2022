namespace Projeto.BusinessLogicLayer
{
    public interface IManager<T>
    {
        bool Validar(T objeto);
        void Salvar(T objeto);
    }
}