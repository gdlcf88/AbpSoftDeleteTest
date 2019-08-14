using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SoftDeleteTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(SoftDeleteTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class SoftDeleteTestConsoleApiClientModule : AbpModule
    {
        
    }
}
