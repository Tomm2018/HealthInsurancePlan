using AutoMapper;
using HealthInsuranceApi.DTOs;
using HealthInsuranceApi.Models;
using HealthInsuranceApi.Repositories;
using System.Numerics;

namespace HealthInsuranceApi.Services
{
    public class InsuranceService
    {
        private readonly InsuranceRepository _repository;
        private readonly IMapper _mapper;

        public InsuranceService(InsuranceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<InsurancePlanDto>> GetAvailablePlansAsync()
        {
            
               var plans = await _repository.GetAllPlansAsync();
            return _mapper.Map<List<InsurancePlanDto>>(plans);
        }

        public async Task SelectPlanAsync(int userId, int planId)
        {
            var selection = new UserSelection
            {
                UserId = userId,
                PlanId = planId
            };

            await _repository.AddUserSelectionAsync(selection);
        }
    }

}
