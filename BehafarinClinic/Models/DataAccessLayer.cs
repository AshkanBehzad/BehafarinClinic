using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
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