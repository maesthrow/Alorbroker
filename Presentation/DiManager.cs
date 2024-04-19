using Application.Services;
using Domain.Interfaces;
using Domain.Models.ConsolidatedListFile;
using Infrastructure.Data.ConsolidatedListFile;
using Infrastructure.FileProcessors;
using Infrastructure.Mappers.ConsolidatedListFile;
using Infrastructure.Services;
using Infrastructure.UserInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{

    // класс для настройки внедрения зависимостей
    public static class DiManager
    {
        #region Static Fields

        private const string ConfigFileName = "appsettings.json";

        #endregion

        #region Methods

        // метод конфигурирует и возвращает объект ServiceProvider для DI контейнера
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // регистрация контекста и репозиториев для работы с БД
            var connectionString = GetConnectionString();
            services.AddDbContext<ConsolidatedListDbContext>(options => options.UseSqlServer(connectionString));

            services.AddSingleton<IRepository<ConsolidatedList>, ConsolidatedListRepository>();

            // регистрация мапперов для моделей xml-файлов и моделей базы данных
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

            // регистрация сервисов для обработки данных
            services.AddSingleton<IXmlDataService<CONSOLIDATED_LIST>, ConsolidatedListXmlDataService>();

            services.AddSingleton<IDataService<CONSOLIDATED_LIST>, ConsolidatedListDataService>();

            services.AddSingleton<IFileProcessor, ConsolidatedListProcessor>();

            services.AddSingleton<IFileProcessorFactory, FileProcessorFactory>();

            // регистрация пользовательского интерфейса
            services.AddSingleton<IUserInterface, ConsoleUserInterface>();

            // регистрация списка обработчиков(процессоров) для всех возможных файлов
            services.AddTransient<IEnumerable<IFileProcessor>>(sp =>
                new List<IFileProcessor>
                {
                    sp.GetRequiredService<IFileProcessorFactory>().CreateProcessor("consolidated-list.xml")
                });

            // регистрация основного класса Program
            services.AddSingleton<Program>();

            return services.BuildServiceProvider();
        }

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(ConfigFileName, true, true);

            IConfiguration configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("LocalConnection") ??
                                   configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), ConfigFileName);

                throw new InvalidOperationException(
                    $"Не найдена строка подключения к базе данных. Проверьте наличие файла '{configFilePath}'");
            }

            return connectionString;
        }

        #endregion
    }

}