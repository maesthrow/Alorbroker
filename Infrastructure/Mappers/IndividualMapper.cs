using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Mappers
{

    public class IndividualMapper
        : IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL, Individual>,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL, Individual>
    {
        #region Fields

        private readonly ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS, IndividualAlias>
            _aliasMapper;

        private readonly ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS, IndividualAddress>
            _addressMapper;

        private readonly
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH, IndividualDateOfBirth>
            _dateOfBirthMapper;

        private readonly
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH, IndividualPlaceOfBirth>
            _individualPlaceOfBirthMapper;

        private readonly
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT, IndividualDocument>
            _individualDocumentMapper;

        #endregion

        #region Constructors

        public IndividualMapper(
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS, IndividualAlias>
                aliasMapper,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS, IndividualAddress>
                addressMapper,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH, IndividualDateOfBirth>
                dateOfBirthMapper,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH, IndividualPlaceOfBirth>
                individualPlaceOfBirthMapper,
            ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT, IndividualDocument>
                individualDocumentMapper)
        {
            _aliasMapper = aliasMapper;
            _addressMapper = addressMapper;
            _dateOfBirthMapper = dateOfBirthMapper;
            _individualPlaceOfBirthMapper = individualPlaceOfBirthMapper;
            _individualDocumentMapper = individualDocumentMapper;
        }

        #endregion

        #region Interfaces

        #region ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL,Individual>

        public IEnumerable<Individual> MapCollection(IEnumerable<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL> collection)
            => (collection ?? Enumerable.Empty<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL>())
                .Select(Map)
                .ToList();

        #endregion

        #region IMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL,Individual>

        public Individual Map(CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL entity) => new()
        {
            DataId = entity.DATAID,
            FirstName = entity.FIRST_NAME,
            LastName = entity.SECOND_NAME,
            ThirdName = entity.THIRD_NAME,
            FourthName = entity.FOURTH_NAME,
            UnListType = entity.UN_LIST_TYPE,
            ReferenceNumber = entity.REFERENCE_NUMBER,
            ListedOn = entity.LISTED_ON,
            Gender = entity.GENDER,
            NameOriginalScript = entity.NAME_ORIGINAL_SCRIPT,
            Comments = entity.COMMENTS1,
            SortKey = entity.SORT_KEY,
            SortKeyLastMod = entity.SORT_KEY_LAST_MOD,
            Aliases = _aliasMapper.MapCollection(entity.INDIVIDUAL_ALIAS).ToList(),
            Addresses = _addressMapper.MapCollection(entity.INDIVIDUAL_ADDRESS).ToList(),
            DatesOfBirth = _dateOfBirthMapper.MapCollection(entity.INDIVIDUAL_DATE_OF_BIRTH).ToList(),
            PlacesOfBirth = _individualPlaceOfBirthMapper.MapCollection(entity.INDIVIDUAL_PLACE_OF_BIRTH).ToList(),
            Documents = _individualDocumentMapper.MapCollection(entity.INDIVIDUAL_DOCUMENT).ToList()
        };

        #endregion

        #endregion
    }

}