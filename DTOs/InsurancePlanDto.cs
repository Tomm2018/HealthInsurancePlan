namespace HealthInsuranceApi.DTOs
{
    public class InsurancePlanDto
    {
        public string? Name { get; set; }
        public string? Coverage { get; set; }
        public decimal Price { get; set; } = 0;
    }
}
