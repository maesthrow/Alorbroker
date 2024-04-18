using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class IndividualPlaceOfBirthMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH, IndividualPlaceOfBirth>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH, IndividualPlaceOfBirth>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH,IndividualPlaceOfBirth>

        public IEnumerable<IndividualPlaceOfBirth> MapCollection(
            IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH,IndividualPlaceOfBirth>

        public IndividualPlaceOfBirth Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH entity)
            => new()
            {
                Street = entity.STREET,
                City = entity.CITY,
                StateProvince = entity.STATE_PROVINCE,
                Country = entity.COUNTRY,
                Note = entity.NOTE
            };

        #endregion

        #endregion
    }

}