using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShopMvc.Areas.Admin.Controllers
{
    public class RentController : Controller
    {
        // GET: RentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
