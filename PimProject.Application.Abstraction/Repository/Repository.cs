using Microsoft.EntityFrameworkCore;
using PimProject.Application.Abstraction.Domain;
using PimProject.Application.Abstraction.Interface;
using System.Collections.Generic;

namespace PimProject.Application.Abstraction.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly DbContext Context;
        protected readonly DbSet<T> DBSet;


        public Repository(DbContext context)
        {
            Context = context;
            DBSet = Context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            await DBSet.AddAsync(entity);
        }

        public virtual void Delete(T entity)
        {
            DBSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DBSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(string id)
        {
            return await DBSet.FindAsync(id);
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public virtual void Update(T entity)
        {
            var entityEntry = Context.Entry(entity);
            DBSet.Update(entity);
        }

    }
}
