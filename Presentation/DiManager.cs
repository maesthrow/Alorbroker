using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;
using Infrastructure.Data.ConsolidatedListFile;
using Infrastructure.Mappers.ConsolidatedListFile;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{

    public static class DiManager
    {
        #region Methods

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var connectionString = GetConnectionString();
            services.AddDbContext<ConsolidatedListDbContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IRepository<ConsolidatedList>, ConsolidatedListRepository>();

            services
                .AddSingleton<ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS, IndividualAlias>
                    , IndividualAliasMapper>();

            services
                .AddSingleton<
                    ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS, IndividualAddress>,
                    IndividualAddressMapper>();

            services
                .AddSingleton<
                    ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH,
                        IndividualDateOfBirth>, IndividualDateOfBirthMapper>();

            services
                .AddSingleton<
                    ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH,
                        IndividualPlaceOfBirth>, IndividualPlaceOfBirthMapper>();

            services
                .AddSingleton<
                    ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT, IndividualDocument>,
                    IndividualDocumentMapper>();

            services
                .AddSingleton<ICollectionMapper<CONSOLIDATED_LISTINDIVIDUALSINDIVIDUAL, Individual>,
                    IndividualMapper>();

            services
                .AddSingleton<ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS, EntityAlias>,
                    EntityAliasMapper>();

            services
                .AddSingleton<ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS, EntityAddress>,
                    EntityAddressMapper>();

            services.AddSingleton<ICollectionMapper<CONSOLIDATED_LISTENTITIESENTITY, Entity>, EntityMapper>();

            services.AddSingleton<IMapper<CONSOLIDATED_LIST, ConsolidatedList>, ConsolidatedListMapper>();

            services.AddSingleton<IXmlDataService<CONSOLIDATED_LIST>, ConsolidatedListXmlDataService>();

            services.AddSingleton<IDataService<CONSOLIDATED_LIST>, ConsolidatedListDataService>();

            services.AddSingleton<Program>();

            return services.BuildServiceProvider();
        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            IConfiguration configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("LocalConnection") ??
                                   configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Не найдена строка подключения к базе данных.");

            return connectionString;
        }

        #endregion
    }

}