namespace HealthInsuranceApi.Models
{
    public class InsurancePlan
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Coverage { get; set; }
        public decimal Price { get; set; }
    }
}
