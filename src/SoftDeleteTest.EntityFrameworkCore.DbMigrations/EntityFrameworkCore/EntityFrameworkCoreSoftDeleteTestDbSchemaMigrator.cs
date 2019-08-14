using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoftDeleteTest.Data;
using Volo.Abp.DependencyInjection;

namespace SoftDeleteTest.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreSoftDeleteTestDbSchemaMigrator 
        : ISoftDeleteTestDbSchemaMigrator, ITransientDependency
    {
        private readonly SoftDeleteTestMigrationsDbContext _dbContext;

        public EntityFrameworkCoreSoftDeleteTestDbSchemaMigrator(SoftDeleteTestMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}