using Proxy;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AccessManagement.Controllers
{
    public class ItemController : Controller
    {
        //
        // GET: /Item/

        public async Task<ActionResult> Index()
        {
            ItemProxy proxy = new ItemProxy();
            string rootUrl = ConfigurationManager.AppSettings.GetValues("ServiceURL")[0];
            var items = await proxy.GetList(rootUrl, "API/ItemRepository");
            return View(items);
        }

        //
        // GET: /Item/Details/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // GET: /Item/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Item/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Item/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
