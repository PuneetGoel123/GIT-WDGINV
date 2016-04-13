namespace AssetManagementService.Tests.Controllers
{
    using AssetManagementService.Controllers;
    using DataModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ItemRepositoryControllerTest
    {
        [TestMethod]
        public void Get()
        {
            ItemRepositoryController controller = new ItemRepositoryController();

            // Act
            IEnumerable<Item> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ItemRepositoryController controller = new ItemRepositoryController();

            // Act
            Item result = controller.Get(1);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ItemRepositoryController controller = new ItemRepositoryController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ItemRepositoryController controller = new ItemRepositoryController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ItemRepositoryController controller = new ItemRepositoryController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
