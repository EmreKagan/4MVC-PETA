using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
