using SoftDeleteTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SoftDeleteTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SoftDeleteTestEntityFrameworkCoreDbMigrationsModule),
        typeof(SoftDeleteTestApplicationContractsModule)
        )]
    public class SoftDeleteTestDbMigratorModule : AbpModule
    {
        
    }
}
