using Microsoft.AspNetCore.Mvc;

namespace BookShopMvc.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
