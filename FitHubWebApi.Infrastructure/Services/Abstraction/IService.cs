using System.Threading.Tasks;

namespace FitHubWebApi.Infrastructure.Services.Abstraction
{
    public interface IService<T> where T : class
    {
        Task Add(T userDto);
        Task<T> GetById(int id);
        Task Update(T entity);
        Task Delete(int id);
    }
}
