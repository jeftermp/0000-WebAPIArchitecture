using Data.Context;
using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        protected DbSet<T> dbSet;
        protected readonly BookContext context;
        private readonly IConfiguration _config;

        public BaseRepository(BookContext context, IConfiguration config)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            this._config = config;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Cadastrar(T obj)
        {
            this.context.Add(obj);
            context.SaveChanges();
        }
        public IEnumerable<T> Listar(bool? ativo = true)
        {
            IQueryable<T> query = this.context.Set<T>().Where(w => ativo.Value);
            return query.ToList();
        }

        public T ObterPorId(int id)
        {
            return this.context.Set<T>().Find(id);
        }
    }
}