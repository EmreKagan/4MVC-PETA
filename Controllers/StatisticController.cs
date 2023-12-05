using Microsoft.AspNetCore.Mvc;

namespace KisiselHarcamaTakibi.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Statistics()
        {
            return View();
        }
    }
}
