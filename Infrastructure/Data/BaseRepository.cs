using Domain.Interfaces;
using Domain.Models;
using Domain.Models.ConsolidatedListFile;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{

    public abstract class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        #region Fields

        protected readonly BaseApplicationDbContext _context;

        #endregion

        #region Constructors

        protected BaseRepository(BaseApplicationDbContext context) => _context = context;

        #endregion

        #region Interfaces

        #region IRepository<T>

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await _context.GetData<T>().ToListAsync();

        public virtual async Task<T> GetByIdAsync(int id) => await _context.GetData<T>().FindAsync(id);

        public virtual async Task AddAsync(T entity)
        {
            _context.GetData<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _context.GetData<T>().FindAsync(id);

            if (entity != null)
            {
                _context.GetData<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        #endregion

        #endregion
    }

}