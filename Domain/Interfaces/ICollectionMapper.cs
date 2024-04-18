using Domain.Models;
using Domain.Models.ConsolidatedListFile;

namespace Domain.Interfaces
{

    public interface ICollectionMapper<in TSource, out TDestination>
        where TSource : class
        where TDestination : BaseModel
    {
        #region Methods

        IEnumerable<TDestination> MapCollection(IEnumerable<TSource> collection);

        #endregion
    }

}