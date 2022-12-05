using BiblosBack.Core.Application.Interfaces.Repositories;
using BiblosBack.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblosBack.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private readonly BiblosBackContext _dbContext;
        public GenericRepository(BiblosBackContext context)
        {
            _dbContext = context;
        }

        public virtual async Task<Entity> AddAsync(Entity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Entity> UpdateAsync(Entity entity, int id)
        {
            Entity entry = await _dbContext.Set<Entity>().FindAsync(id);
            _dbContext.Entry(entry).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();

            return entry;
        }

        public async Task DeleteAsync(Entity entity)
        {
            _dbContext.Set<Entity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Entity>> GetAllAsync()
        {
            return await _dbContext.Set<Entity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Entity>().FindAsync(id);
        }

        public virtual async Task<List<Entity>> GetAllWithIncludesAsync(List<string> props)
        {
            var query = _dbContext.Set<Entity>().AsNoTracking().AsQueryable();

            foreach (string prop in props)
            {
                query = query.Include(prop);
            }

            return await query.ToListAsync();
        }

        public virtual async Task<Entity> GetByIdWithIncludeAsync(int id, List<string> props, List<string> colls)
        {
            var query = await _dbContext.Set<Entity>().FindAsync(id);

            foreach (string prop in props)
            {
                _dbContext.Entry(query).Reference(prop).Load();
            }

            foreach (string coll in colls)
            {
                _dbContext.Entry(query).Collection(coll).Load();
            }

            return query;
        }
    }
}
