using FitHubWebApi.Core.Repositories.Base;
using FitHubWebApi.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FitHubWebApi.Infrastructure.Repositories.Base
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly FitHubWebApiContext Context;
        protected readonly DbSet<T> Table;

        public BaseRepository(FitHubWebApiContext context)
        {
            Context = context;
            Table = Context.Set<T>();
        }

        public virtual async Task Add(T entity)
        {
            await Table.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return Table.AsQueryable();
        }
        public virtual async Task<T> GetById(object id)
        {
            return await Table.FindAsync(id);
        }

        public virtual async Task Remove(T entity)
        {
            Table.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            Table.Update(entity);
            await Context.SaveChangesAsync();
        }

    }
}
