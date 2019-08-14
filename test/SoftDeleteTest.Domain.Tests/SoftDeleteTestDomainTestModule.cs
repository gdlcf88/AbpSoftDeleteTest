using SoftDeleteTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SoftDeleteTest
{
    [DependsOn(
        typeof(SoftDeleteTestEntityFrameworkCoreTestModule)
        )]
    public class SoftDeleteTestDomainTestModule : AbpModule
    {

    }
}