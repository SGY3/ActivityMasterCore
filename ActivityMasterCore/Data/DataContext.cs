using ActivityMasterCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ActivityMasterCore.ViewModels;

namespace ActivityMasterCore.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<ActivityMasterCore.ViewModels.RoleStore> RoleStore { get; set; }
    }
}
