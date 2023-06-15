using DAL.DbbContext;
using DAL.Entities;
using DAL.IRepostory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NewsRepository : INewsRepository
    {
        private readonly AppDbContext _appDbContext;
        public NewsRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public async Task<bool> Add(News entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }
            await _appDbContext.News.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(News entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }
            _appDbContext.News.Remove(entity);
            return await Save();
        }

        public Task<bool> DeleteAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<News>> FindActives()
        {
            try
            {
                var actives = await _appDbContext.News.Where(c => c.IsActive).ToListAsync();
                return actives;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public Task<News> FindByIdWhitImage(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<News>> GetAllAsync()
        {
            try
            {
                var result = await _appDbContext.News.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
          
        }

        public Task<News> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<News> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistes(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Save()
        {
            var saving = await _appDbContext.SaveChangesAsync();
            if (saving == 0)
            {
                return false;
            }
                return true;
        }

        public Task<bool> Update(News entity)
        {
            throw new NotImplementedException();
        }
    }
}
