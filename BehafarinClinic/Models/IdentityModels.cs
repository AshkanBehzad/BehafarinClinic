using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BehafarinClinic.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public Gender Gender {get;set;}


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Personnel Personnel { get; set; }

        public int? PersonnelId { get; set; }

        
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
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Entity<HourlyEvaluation>()
                .HasMany<Personnel>(he => he.Nurses)
                .WithMany(nurse => nurse.Evaluations)
                .Map(cs =>
                {
                    cs.MapLeftKey("HEvalId");
                    cs.MapRightKey("NurseId");
                    cs.ToTable("EvaluationNurse");
                });

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<ConsumableGoods> ConsumableGoods { get; set; }
        public DbSet<DialysisPatient> DialysisPatients { get; set; }
        public DbSet<DialysisSession> DialysisSessions { get; set; }
        public DbSet<ConsumedGoodsItem> ConsumedGoodsItems { get; set; }
        
        public DbSet<HourlyEvaluation> HourlyEvaluations { get; set; }
        public DbSet<InfirmaryPersonnel> InfirmaryPersonnels { get; set; }
        public DbSet<InfirmaryReception> InfirmaryReceptions { get; set; }
        public DbSet<InsuranceOrganization> InsuranceOrganizations { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        
    }
    
}