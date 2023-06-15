using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepostory
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> DeleteAll();
        //Task<ICollection<T>> GetAll();
        Task<ICollection<T>> GetAllAsync();
       Task<T> GetById(int id);
        Task<T> GetByName(string name);
        Task<bool> IsExistes(int id);
        Task<bool> Save();
    }
}
