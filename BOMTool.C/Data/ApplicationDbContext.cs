using Microsoft.EntityFrameworkCore;
using BOMTool.M;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace BOMTool.C.Data
{
    public class ApplicationDbContext : DbContext

    {
        private User _user;
       // private readonly IConfiguration _configuration;

        public ApplicationDbContext() : base()
        {

        }

        public ApplicationDbContext(DbContextOptions options, IHttpContextAccessor httpContextAccesor) : base(options)
        {
            if (httpContextAccesor.HttpContext != null)
            {
                if (httpContextAccesor.HttpContext.User.Identity.IsAuthenticated)
                {
                    var _userId = Guid.ParseExact(httpContextAccesor.HttpContext.User.Claims.Where(x => x.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value, "D");
                    _user = this.User.Find(_userId);
                }
            }
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(e => e.Entity is BaseModel && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entities)
            {
                ((BaseModel)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseModel)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseModel && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseModel)entityEntry.Entity).UpdatedAt = DateTime.Now;
                ((BaseModel)entityEntry.Entity).UpdatedBy = _user;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseModel)entityEntry.Entity).CreatedAt = DateTime.Now;
                    ((BaseModel)entityEntry.Entity).CreatedBy = _user;
                }
            }
            return (await base.SaveChangesAsync(true, cancellationToken));
        }

        public DbSet<Location> Location { get; set;  }

        public DbSet<User> User { get; set;  }
 
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<User>(x =>
             {
                 x.HasIndex(x => x.Sso)
                 .IsUnique();
             });

            Builder.Entity<Location>(l =>
                {
                    l.HasIndex(l => l.Name)
                    .IsUnique();
                    l.HasIndex(l => l.Code)
                    .IsUnique();
                });
        }
   }        

}
