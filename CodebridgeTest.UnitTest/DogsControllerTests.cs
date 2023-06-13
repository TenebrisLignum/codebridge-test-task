using Codebridge_Test.Controllers;
using Codebridge_Test.Services.Interfaces;
using Codebridge_Test.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CodebridgeTest.UnitTest
{
    public class DogsControllerTests
    {
        [Test]
        public async Task Index_Tests()
        {
            var filter = new DogTableFilterViewModel();

            var dogServiceMoq = new Mock<IDogsService>();
            dogServiceMoq.Setup(x => x.GetTable(filter));

            DogsController controller = new(dogServiceMoq.Object);

            var result = await controller.Index(filter);

            Assert.IsAssignableFrom<ViewResult>(result);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void CreateView_Tests()
        {
            var dogServiceMoq = new Mock<IDogsService>();
            DogsController controller = new(dogServiceMoq.Object);

            var result = controller.Create();

            Assert.IsAssignableFrom<ViewResult>(result);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public async Task Create_Tests()
        {
            var dogVM = TestDogVM();
            var dogServiceMoq = new Mock<IDogsService>();
            dogServiceMoq.Setup(x => x.Create(dogVM));

            DogsController controller = new(dogServiceMoq.Object);

            var result = await controller.CreateAsync(dogVM);

            Assert.IsAssignableFrom<RedirectToActionResult>(result);
        }

        private static DogViewModel TestDogVM()
        {
            return new DogViewModel
            {
                Name = "Test Dog",
                Color = "Black",
                TailLength = 10,
                Weight = 11
            };
        }
    }
}
