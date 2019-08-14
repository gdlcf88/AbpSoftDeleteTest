using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SoftDeleteTest.Data
{
    /* This is used if database provider does't define
     * ISoftDeleteTestDbSchemaMigrator implementation.
     */
    public class NullSoftDeleteTestDbSchemaMigrator : ISoftDeleteTestDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}