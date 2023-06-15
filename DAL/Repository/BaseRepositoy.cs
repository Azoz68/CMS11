using DAL.DbbContext;
using DAL.IRepostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class BaseRepositoy<T>
    {
        private readonly AppDbContext _appContext;
        public BaseRepositoy(AppDbContext dbContext)
        {
            _appContext = dbContext;   
        }
        //public async Task<int> Add(int id)
        //{
        //    return;
        //}
    }
}
