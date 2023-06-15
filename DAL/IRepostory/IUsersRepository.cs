using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepostory
{
    public interface IUsersRepository :IRepositoryBase<Users>
    {
        Task<ICollection<Users>> FindRoles(int id);
    }
}
