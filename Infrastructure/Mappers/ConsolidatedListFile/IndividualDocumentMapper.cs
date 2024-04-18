using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Mappers.ConsolidatedListFile
{

    public class IndividualDocumentMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT, IndividualDocument>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT, IndividualDocument>
    {
        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT,IndividualDocument>

        public IEnumerable<IndividualDocument> MapCollection(
            IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT>())
                .Select(Map)
                .ToList();

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT,IndividualDocument>

        public IndividualDocument Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT entity)
            => new()
            {
                TypeOfDocument = entity.TYPE_OF_DOCUMENT,
                TypeOfDocument2 = entity.TYPE_OF_DOCUMENT2,
                Number = entity.NUMBER,
                IssuingCountry = entity.ISSUING_COUNTRY,
                DateOfIssue = entity.DATE_OF_ISSUE,
                CityOfIssue = entity.CITY_OF_ISSUE,
                Note = entity.NOTE,
                CountryOfIssue = entity.COUNTRY_OF_ISSUE
            };

        #endregion

        #endregion
    }

}