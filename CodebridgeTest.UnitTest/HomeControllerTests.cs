using CodebridgeTest.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CodebridgeTest.UnitTest
{
    internal class HomeControllerTests
    {
        [Test]
        public void Index_Tests()
        {
            HomeController controller = new();
            var result = controller.Index();

            Assert.IsAssignableFrom<ViewResult>(result);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void Ping_Tests()
        {
            var controller = new HomeController();

            var result = controller.Ping();
            var okResult = result as OkObjectResult;

            Assert.That(okResult, Is.Not.Null);
            Assert.That(okResult.StatusCode, Is.EqualTo(200));
            Assert.That(okResult.Value, Is.EqualTo("Dogs house service. Version 1.0.1"));
        }
    }
}
