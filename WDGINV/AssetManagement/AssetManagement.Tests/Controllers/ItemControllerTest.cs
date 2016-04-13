namespace AccessManagement.Tests.Controllers
{
    using AccessManagement.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    [TestClass]
    public class ItemControllerTest
    {
        [TestMethod]
        public async Task Index()
        {
            ItemController controller = new ItemController();
            ViewResult result = await controller.Index() as ViewResult;
            Assert.AreNotEqual(result.Model, null);
        }
    }
}
