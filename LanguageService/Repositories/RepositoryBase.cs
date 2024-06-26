﻿using Llp.Language.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Llp.Language.Repositories
{
    public class RepositoryBase
    {
    }
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly LlpDbContext _context;
        protected readonly ILogger _logger;

        public RepositoryBase(LlpDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            _ = await _context.Set<T>().AddAsync(entity);
            _ = await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _ = _context.Set<T>().Update(entity);
            _ = await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _ = _context.Set<T>().Remove(entity);
            _ = await _context.SaveChangesAsync();
        }
    }
}
