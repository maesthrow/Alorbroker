using Domain.Models.ConsolidatedListFile;

namespace Infrastructure.Data.ConsolidatedListFile
{

    public class ConsolidatedListRepository : BaseRepository<ConsolidatedList>
    {
        #region Constructors

        public ConsolidatedListRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualRepository : BaseRepository<Individual>
    {
        #region Constructors

        public IndividualRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualAliasRepository : BaseRepository<IndividualAlias>
    {
        #region Constructors

        public IndividualAliasRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualAddressRepository : BaseRepository<IndividualAddress>
    {
        #region Constructors

        public IndividualAddressRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualDateOfBirthRepository : BaseRepository<IndividualDateOfBirth>
    {
        #region Constructors

        public IndividualDateOfBirthRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualPlaceOfBirthRepository : BaseRepository<IndividualPlaceOfBirth>
    {
        #region Constructors

        public IndividualPlaceOfBirthRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class IndividualDocumentRepository : BaseRepository<IndividualDocument>
    {
        #region Constructors

        public IndividualDocumentRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class EntityRepository : BaseRepository<Entity>
    {
        #region Constructors

        public EntityRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class EntityAliasRepository : BaseRepository<EntityAlias>
    {
        #region Constructors

        public EntityAliasRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

    public class EntityAddressRepository : BaseRepository<EntityAddress>
    {
        #region Constructors

        public EntityAddressRepository(ConsolidatedListDbContext context) : base(context) { }

        #endregion
    }

}