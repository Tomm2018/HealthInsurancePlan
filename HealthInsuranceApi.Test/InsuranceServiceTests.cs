using AutoMapper;
using HealthInsuranceApi.Models;
using HealthInsuranceApi.Repositories;
using HealthInsuranceApi.Services;
using Moq;

namespace HealthInsuranceApi.Test
{
    public class InsuranceServiceTests
    {
        [Fact]
        public async Task GetAvailablePlansAsync_ReturnsPlans()
        {
            var mockRepo = new Mock<InsuranceRepository>();
            mockRepo.Setup(x => x.GetAllPlansAsync()).ReturnsAsync(new List<InsurancePlan>
        {
            new InsurancePlan { Id = 1, Name = "Basic Plan", Coverage = "Hospital", Price = 100 }
        });

            var service = new InsuranceService(mockRepo.Object, new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()))));

            var result = await service.GetAvailablePlansAsync();

            Assert.Single(result);
            Assert.Equal("Basic Plan", result[0].Name);
        }
    }
}