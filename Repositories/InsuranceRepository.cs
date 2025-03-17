using HealthInsuranceApi.Configurations;
using HealthInsuranceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthInsuranceApi.Repositories
{
    public class InsuranceRepository
    {
        private readonly InsuranceDbContext _context;

        public InsuranceRepository(InsuranceDbContext context)
        {
            _context = context;
        }

        public async Task<List<InsurancePlan>> GetAllPlansAsync()
        {
            return await _context.InsurancePlans.ToListAsync();
        }

        public async Task AddUserSelectionAsync(UserSelection selection)
        {
            _context.UserSelections.Add(selection);
            await _context.SaveChangesAsync();
        }
    }
}
