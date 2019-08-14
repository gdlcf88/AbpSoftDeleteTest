using SoftDeleteTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SoftDeleteTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SoftDeleteTestController : AbpController
    {
        protected SoftDeleteTestController()
        {
            LocalizationResource = typeof(SoftDeleteTestResource);
        }
    }
}