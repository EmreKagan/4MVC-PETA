using Microsoft.AspNetCore.Mvc;

namespace KisiselHarcamaTakibi.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}
