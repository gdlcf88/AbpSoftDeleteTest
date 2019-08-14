using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace SoftDeleteTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class SoftDeleteTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SoftDeleteTest";
    }
}
