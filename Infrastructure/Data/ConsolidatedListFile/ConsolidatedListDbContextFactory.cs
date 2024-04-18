using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.ConsolidatedListFile
{

    public class ConsolidatedListDbContextFactory : IDesignTimeDbContextFactory<ConsolidatedListDbContext>
    {
        #region Interfaces

        #region IDesignTimeDbContextFactory<ConsolidatedListDbContext>

        public ConsolidatedListDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ConsolidatedListDbContext>();
            var connectionString = GetConnectionString();
            optionsBuilder.UseSqlServer(connectionString);

            return new ConsolidatedListDbContext(optionsBuilder.Options);
        }

        #endregion

        #endregion

        #region Methods

        private static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", true, true);

            IConfiguration configuration = builder.Build();

            var connectionString = configuration.GetConnectionString("LocalConnection") ??
                                   configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Не найдена строка подключения к БД");

            return connectionString;
        }

        #endregion
    }

}