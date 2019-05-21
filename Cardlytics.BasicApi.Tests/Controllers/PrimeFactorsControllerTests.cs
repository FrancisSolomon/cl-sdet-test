using Cardlytics.BasicApi.Tests.Fixtures;

using FluentAssertions;

using NUnit.Framework;

namespace Cardlytics.BasicApi.Tests.Controllers
{
    [TestFixture]
    public class PrimeFactorsControllerTests
    {
        private TestServerFixture _testServer;

        [SetUp]
        public void Setup()
        {
            _testServer = new TestServerFixture();
        }

        [TearDown]
        public void Teardown()
        {
            _testServer.Dispose();
        }
    }
}
