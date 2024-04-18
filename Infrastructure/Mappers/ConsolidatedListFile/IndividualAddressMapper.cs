using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class IndividualAddressMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS, IndividualAddress>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS, IndividualAddress>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS,IndividualAddress>

        public IEnumerable<IndividualAddress> MapCollection(
            IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS>())
                .Select(Map);

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS,IndividualAddress>

        public IndividualAddress Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS entity)
            => new()
            {
                Street = entity.STREET,
                City = entity.CITY,
                StateProvince = entity.STATE_PROVINCE,
                Country = entity.COUNTRY,
                ZipCode = entity.ZIP_CODE,
                Note = entity.NOTE
            };

        #endregion

        #endregion
    }

}