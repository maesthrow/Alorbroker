using Domain.Models;
using Domain.Models.ConsolidatedListFile;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{

    public interface IApplicationDbContext
    {
        #region Methods

        DbSet<T>? GetData<T>() where T : BaseModel;

        #endregion
    }

}