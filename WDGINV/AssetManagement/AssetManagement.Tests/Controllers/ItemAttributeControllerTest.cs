namespace AccessManagement.Tests.Controllers
{
    using AccessManagement.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    [TestClass]
    public class ItemAttributeControllerTest
    {
        [TestMethod]
        public async Task Index()
        {
            ItemAttributeController controller = new ItemAttributeController();
            ViewResult result = await controller.Index() as ViewResult;
            Assert.AreNotEqual(result.Model, null);
        }
    }
}
