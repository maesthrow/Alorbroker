using Domain.Models.ConsolidatedListFile;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.ConsolidatedListFile
{

    public class ConsolidatedListDbContext : BaseApplicationDbContext
    {
        #region Constructors

        public ConsolidatedListDbContext(DbContextOptions<ConsolidatedListDbContext> options)
            : base(options) { }

        #endregion

        #region Properties

        public DbSet<ConsolidatedList> ConsolidatedLists { get; set; }

        public DbSet<Individual> Individuals { get; set; }

        public DbSet<IndividualAlias> IndividualAliases { get; set; }

        public DbSet<IndividualAddress> IndividualAddresses { get; set; }

        public DbSet<IndividualDateOfBirth> IndividualDateOfBirths { get; set; }

        public DbSet<IndividualPlaceOfBirth> IndividualPlaceOfBirths { get; set; }

        public DbSet<IndividualDocument> IndividualDocuments { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<EntityAlias> EntityAliases { get; set; }

        public DbSet<EntityAddress> EntityAddresses { get; set; }

        #endregion

        #region Methods

        public override DbSet<T>? GetData<T>()
        {
            return typeof(T) switch
            {
                { } t when t == typeof(ConsolidatedList) => ConsolidatedLists as DbSet<T>,
                { } t when t == typeof(Individual) => Individuals as DbSet<T>,
                { } t when t == typeof(IndividualAlias) => IndividualAliases as DbSet<T>,
                { } t when t == typeof(IndividualAddress) => IndividualAddresses as DbSet<T>,
                { } t when t == typeof(IndividualDateOfBirth) => IndividualDateOfBirths as DbSet<T>,
                { } t when t == typeof(IndividualPlaceOfBirth) => IndividualPlaceOfBirths as DbSet<T>,
                { } t when t == typeof(IndividualDocument) => IndividualDocuments as DbSet<T>,
                { } t when t == typeof(Entity) => Entities as DbSet<T>,
                { } t when t == typeof(EntityAlias) => EntityAliases as DbSet<T>,
                { } t when t == typeof(EntityAddress) => EntityAddresses as DbSet<T>,
                var _ => throw new ArgumentException("Неизвестный тип модели данных")
            };
        }

        #endregion
    }

}