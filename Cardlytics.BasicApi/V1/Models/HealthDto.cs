namespace Cardlytics.BasicApi.V1.Models
{
    public class HealthDto
    {
        public bool ControllerHealthy { get; set; }

        public bool ServiceHealthy { get; set; }

        public string HealthMessage { get; set; }
    }
}
