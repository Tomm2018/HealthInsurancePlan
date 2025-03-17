using HealthInsuranceApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HealthInsuranceApi.Configurations
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options) { }

        public DbSet<InsurancePlan> InsurancePlans { get; set; }
        public DbSet<UserSelection> UserSelections { get; set; }
    }

}
