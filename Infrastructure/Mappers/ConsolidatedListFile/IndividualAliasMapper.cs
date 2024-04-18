using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class IndividualAliasMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS, IndividualAlias>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS, IndividualAlias>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS,IndividualAlias>

        public IEnumerable<IndividualAlias> MapCollection(
            IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS,IndividualAlias>

        public IndividualAlias Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS entity)
            => new()
            {
                Quality = entity.QUALITY,
                AliasName = entity.ALIAS_NAME,
                Note = entity.NOTE,
                CityOfBirth = entity.CITY_OF_BIRTH,
                CountryOfBirth = entity.COUNTRY_OF_BIRTH,
                DateOfBirth = entity.DATE_OF_BIRTH
            };

        #endregion

        #endregion
    }

}