using AutoMapper;
using HealthInsuranceApi.DTOs;
using HealthInsuranceApi.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthInsuranceApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InsurancePlan, InsurancePlanDto>();
        }
    }

}
