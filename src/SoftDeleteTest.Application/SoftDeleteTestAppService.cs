using System;
using System.Collections.Generic;
using System.Text;
using SoftDeleteTest.Localization;
using Volo.Abp.Application.Services;

namespace SoftDeleteTest
{
    /* Inherit your application services from this class.
     */
    public abstract class SoftDeleteTestAppService : ApplicationService
    {
        protected SoftDeleteTestAppService()
        {
            LocalizationResource = typeof(SoftDeleteTestResource);
        }
    }
}
