using System.Net;

using Cardlytics.BasicApi.Tests.Fixtures;

using FluentAssertions;

using NUnit.Framework;

namespace Cardlytics.BasicApi.Tests.Controllers
{
    [TestFixture]
    public class HealthControllerTests
    {
        private TestServerFixture _testServer;

        [Test]
        public void Health_ShouldReturnSuccessMessage_WhenDatabaseAvailable()
        {
            // Arrange/Act
            _testServer = new TestServerFixture();

            var response = _testServer.Client.GetAsync(@"/health").Result;
            var body = response.Content.ReadAsStringAsync().Result;

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            body.Should().Contain("The API is working correctly.");

            _testServer.Dispose();
        }
    }
}
