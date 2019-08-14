using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SoftDeleteTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(SoftDeleteTestEntityFrameworkCoreModule)
        )]
    public class SoftDeleteTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SoftDeleteTestMigrationsDbContext>();
        }
    }
}
