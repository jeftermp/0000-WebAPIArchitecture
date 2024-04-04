namespace Domain.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Cadastrar(T objeto);
        IEnumerable<T> Listar(Boolean? ativo = true);
        T ObterPorId(Int32 id);
    }
}