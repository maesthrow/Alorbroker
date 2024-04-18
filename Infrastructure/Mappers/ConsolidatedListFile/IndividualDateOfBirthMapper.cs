using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class IndividualDateOfBirthMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH, IndividualDateOfBirth>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH, IndividualDateOfBirth>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH,IndividualDateOfBirth>

        public IEnumerable<IndividualDateOfBirth> MapCollection(
            IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH>())
                .Select(Map)
                .ToList();

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH,IndividualDateOfBirth>

        public IndividualDateOfBirth Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH entity)
            => new()
            {
                TypeOfDate = entity.TYPE_OF_DATE,
                Date = entity.DATE,
                FromYear = entity.FROM_YEAR,
                ToYear = entity.TO_YEAR,
                Note = entity.NOTE,
                Year = entity.YEAR
            };

        #endregion

        #endregion
    }

}