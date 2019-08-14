using Volo.Abp.Modularity;

namespace SoftDeleteTest
{
    [DependsOn(
        typeof(SoftDeleteTestApplicationModule),
        typeof(SoftDeleteTestDomainTestModule)
        )]
    public class SoftDeleteTestApplicationTestModule : AbpModule
    {

    }
}