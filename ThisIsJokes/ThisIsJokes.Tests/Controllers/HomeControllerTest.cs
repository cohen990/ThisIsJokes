namespace ThisIsJokes.Tests.Controllers
{
    using System.Web.Mvc;
    using ThisIsJokes.Controllers;
    using Xunit;

    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
