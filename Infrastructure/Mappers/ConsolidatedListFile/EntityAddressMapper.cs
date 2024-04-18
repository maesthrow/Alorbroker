using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class EntityAddressMapper
        : IMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS, EntityAddress>,
            ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS, EntityAddress>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS,EntityAddress>

        public IEnumerable<EntityAddress> MapCollection(
            IEnumerable<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS>? collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS,EntityAddress>

        public EntityAddress Map(CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS entity)
            => new()
            {
                Street = entity.STREET,
                City = entity.CITY,
                ZipCode = entity.ZIP_CODE,
                StateProvince = entity.STATE_PROVINCE,
                Country = entity.COUNTRY,
                Note = entity.NOTE
            };

        #endregion

        #endregion
    }

}