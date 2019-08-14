using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using SoftDeleteTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SoftDeleteTest.Web.Pages
{
    public abstract class SoftDeleteTestPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<SoftDeleteTestResource> L { get; set; }
    }
}
