using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarouselProject.Controllers;
using System.Web.Mvc;

namespace CarouselPro.Tests.Controllers
{
    [TestClass]
    public class TestHomeController
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
