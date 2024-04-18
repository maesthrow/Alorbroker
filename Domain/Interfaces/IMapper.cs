using Domain.Models;

namespace Domain.Interfaces
{

    public interface IMapper<in TSource, out TDestination>
        where TSource : class
        where TDestination : BaseModel
    {
        #region Methods

        TDestination Map(TSource entity);

        #endregion
    }

}