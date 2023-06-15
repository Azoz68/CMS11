using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepostory
{
    public interface INewsRepository : IRepositoryBase<News>
    {
        Task<News> FindByIdWhitImage(int id);
         Task<IEnumerable<News>> FindActives();
    }
}
