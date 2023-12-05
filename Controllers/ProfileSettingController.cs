using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class ProfileSettingController : Controller
    {
        public IActionResult ProfileSetting()
        {
            return View();
        }
    }
}