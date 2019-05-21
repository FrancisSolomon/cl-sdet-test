using Cardlytics.BasicApi.Services;

using NUnit.Framework;

namespace Cardlytics.BasicApi.Tests.Services
{
    [TestFixture]
    public class PrimeFactorsServiceTests
    {
        private IPrimeFactorsService _service;

        [SetUp]
        public void Setup()
        {
            _service = new PrimeFactorsService();
        }
    }
}
