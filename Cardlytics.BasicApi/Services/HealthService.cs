using Cardlytics.BasicApi.V1.Models;

namespace Cardlytics.BasicApi.Services
{
    public class HealthService : IHealthService
    {
        public HealthDto CheckServiceHealth()
        {
            var healthResult = new HealthDto { ServiceHealthy = true };
            return healthResult;
        }
    }
}