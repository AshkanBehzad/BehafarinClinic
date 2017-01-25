using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BehafarinClinic.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }

    public class BehafarinBdContext : DbContext
    {

        public BehafarinBdContext() : base("BehafarinClinic")
        {

        }

        public DbSet<ConsumableGoods> ConsumableGoods { get; set; }
        public DbSet<DialysisPatient> DialysisPatients { get; set; }
        public DbSet<DialysisSession> DialysisSessions { get; set; }
        public DbSet<ConsummedGoodsItem> ConsummedGoodsItems { get; set; }
        public DbSet<EvaluationNurse> EvaluationNurses { get; set; }
        public DbSet<HourlyEvaluation> HourlyEvaluations { get; set; }
        public DbSet<InfirmaryPersonnel> InfirmaryPersonnels { get; set; }
        public DbSet<InfirmaryReception> InfirmaryReceptions { get; set; }
        public DbSet<InsuranceOrganization> InsuranceOrganizations { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}