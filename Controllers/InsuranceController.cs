using HealthInsuranceApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthInsuranceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsuranceController : ControllerBase
    {
        private readonly InsuranceService _service;

        public InsuranceController(InsuranceService service)
        {
            _service = service;
        }

        [HttpGet("plans")]
        public async Task<IActionResult> GetPlans()
        {
            var plans = await _service.GetAvailablePlansAsync();
            return Ok(plans);
        }

        [HttpPost("select")]
        public async Task<IActionResult> SelectPlan(int userId, int planId)
        {
            await _service.SelectPlanAsync(userId, planId);
            return Ok(new { Message = "Plan selected successfully" });
        }
    }

}
