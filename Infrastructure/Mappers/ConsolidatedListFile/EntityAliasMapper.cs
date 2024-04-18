using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class EntityAliasMapper
        : IMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS, EntityAlias>,
            ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS, EntityAlias>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS,EntityAlias>

        public IEnumerable<EntityAlias> MapCollection(
            IEnumerable<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS>? collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS,EntityAlias>

        public EntityAlias Map(CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS entity)
            => new()
            {
                Quality = entity.QUALITY,
                AliasName = entity.ALIAS_NAME,
                Note = entity.NOTE
            };

        #endregion

        #endregion
    }

}