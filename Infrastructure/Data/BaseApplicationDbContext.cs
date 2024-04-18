using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{

    public abstract class BaseApplicationDbContext : DbContext, IApplicationDbContext
    {
        #region Constructors

        protected BaseApplicationDbContext(DbContextOptions options) : base(options) { }

        #endregion

        #region Interfaces

        #region IApplicationDbContext

        public abstract DbSet<T>? GetData<T>() where T : BaseModel;

        #endregion

        #endregion
    }

}