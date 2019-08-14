using SoftDeleteTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SoftDeleteTest.Web.Pages
{
    public abstract class SoftDeleteTestPageModel : AbpPageModel
    {
        protected SoftDeleteTestPageModel()
        {
            LocalizationResourceType = typeof(SoftDeleteTestResource);
        }
    }
}