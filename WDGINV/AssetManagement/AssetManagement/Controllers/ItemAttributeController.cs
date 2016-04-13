using Proxy;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using DataModel;
using DataModel.Enum;

namespace AccessManagement.Controllers
{
    public class ItemAttributeController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            if (TempData["Result"] != null)
            {
                ViewBag.Result = "Item attribute updated successfully.";
            }

            ItemAttributeProxy proxy = new ItemAttributeProxy();
            string rootUrl = ConfigurationManager.AppSettings.GetValues("ServiceURL")[0];
            var attribute = await proxy.GetList(rootUrl, "API/ItemAttributeRepository");
            return View(attribute);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            ItemAttributeProxy proxy = new ItemAttributeProxy();
            string rootUrl = ConfigurationManager.AppSettings.GetValues("ServiceURL")[0];
            var attribute = await proxy.GetItem(rootUrl, "API/ItemAttributeRepository", id);
            return View(attribute);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ItemAttribute attribute)
        {
            ItemAttributeProxy proxy = new ItemAttributeProxy();
            string rootUrl = ConfigurationManager.AppSettings.GetValues("ServiceURL")[0];
            string result = await proxy.UpdateAttribute(rootUrl, "API/ItemAttributeRepository", attribute);
            if (result == Result.Success.ToString())
            {
                TempData["Result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Result = "Could not update the attribute. Please try again later.";
            }
            return View(attribute);
        }

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ItemAttribute/Create

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


        // GET: /ItemAttribute/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ItemAttribute/Delete/5

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
