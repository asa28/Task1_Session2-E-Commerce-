using Domain_DataLayer.CommonModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain_DataLayer.Repository
{
    public interface IRepository<T> where T : BasicModel
    {        
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChanges();
    }
}
