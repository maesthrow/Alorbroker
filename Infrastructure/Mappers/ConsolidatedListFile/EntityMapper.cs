using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class EntityMapper
        : IMapper<CONSOLIDATED_LISTENTITIESENTITY, Entity>,
            ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITY, Entity>
    {
        #region Fields

        private readonly ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS, EntityAlias>
            _entityAliasMapper;

        private readonly ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS, EntityAddress>
            _entityAddressMapper;

        #endregion

        #region Constructors

        public EntityMapper(ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS, EntityAlias>
                entityAliasMapper,
            ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS, EntityAddress>
                entityAddressMapper)
        {
            _entityAliasMapper = entityAliasMapper;
            _entityAddressMapper = entityAddressMapper;
        }

        #endregion

        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITY,Entity>

        public IEnumerable<Entity> MapCollection(IEnumerable<CONSOLIDATED_LISTENTITIESENTITY> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTENTITIESENTITY>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTENTITIESENTITY,Entity>

        public Entity Map(CONSOLIDATED_LISTENTITIESENTITY entity) => new()
        {
            DataId = entity.DATAID,
            VersionNum = entity.VERSIONNUM,
            Name = entity.FIRST_NAME,
            UnListType = entity.UN_LIST_TYPE,
            ReferenceNumber = entity.REFERENCE_NUMBER,
            ListedOn = entity.LISTED_ON,
            NameOriginalScript = entity.NAME_ORIGINAL_SCRIPT,
            Comments = entity.COMMENTS1,
            SortKey = entity.SORT_KEY,
            SortKeyLastMod = entity.SORT_KEY_LAST_MOD,
            Aliases = _entityAliasMapper.MapCollection(entity.ENTITY_ALIAS).ToList(),
            Addresses = _entityAddressMapper.MapCollection(entity.ENTITY_ADDRESS).ToList()
        };

        #endregion

        #endregion
    }

}