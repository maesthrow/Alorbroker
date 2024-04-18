using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class ConsolidatedListMapper : IMapper<CONSOLIDATED_LIST, ConsolidatedList>
    {
        #region Fields

        private readonly ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL, Individual>
            _individualMapper;

        private readonly ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITY, Entity>
            _entityMapper;

        #endregion

        #region Constructors

        public ConsolidatedListMapper(
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL, Individual> individualMapper,
            ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITY, Entity> entityMapper)
        {
            _individualMapper = individualMapper;
            _entityMapper = entityMapper;
        }

        #endregion

        #region Interfaces

        #region IMapper<CONSOLIDATED_LIST,ConsolidatedList>

        public ConsolidatedList Map(CONSOLIDATED_LIST entity) => new()
        {
            DateGenerated = entity.dateGenerated,
            Individuals = _individualMapper.MapCollection(entity.INDIVIDUALS).ToList(),
            Entities = _entityMapper.MapCollection(entity.ENTITIES).ToList()
        };

        #endregion

        #endregion
    }

}