using Microsoft.EntityFrameworkCore;
using System;
using Projet.Repositories.RepositoriesContracts;
using Projet.Models;

namespace Projet.Repositories.Repositories
{
    public class GenericRepository<T> : GenericRepositoryC<T> where T : class
    {
        protected readonly ApplicationdbContext _context;

        public GenericRepository(ApplicationdbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
