using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace SoftDeleteTest.Web.Pages
{
    public class IndexModel : SoftDeleteTestPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}