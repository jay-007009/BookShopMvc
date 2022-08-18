using Microsoft.AspNetCore.Mvc;

namespace BookShopMvc.Areas.Admin.Controllers
{
    public class BookImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
