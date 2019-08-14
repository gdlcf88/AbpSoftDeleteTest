using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace SoftDeleteTest.Data
{
    public class SoftDeleteTestDbMigrationService : ITransientDependency
    {
        public ILogger<SoftDeleteTestDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly ISoftDeleteTestDbSchemaMigrator _dbSchemaMigrator;

        public SoftDeleteTestDbMigrationService(
            IDataSeeder dataSeeder,
            ISoftDeleteTestDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<SoftDeleteTestDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}