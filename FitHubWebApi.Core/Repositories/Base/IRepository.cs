﻿using System.Linq;
using System.Threading.Tasks;

namespace FitHubWebApi.Core.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);
        Task<T> GetById(int id);
    }
}
