using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence;

public class ApplicationDbContext  : IdentityDbContext<EmployeeAccount>// IApplicationDbContext 
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options)
	{
	}

    public DbSet<Department> Departments { get; set; }
    public DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
    public DbSet<Dependant> Dependants { get; set; }
    public DbSet<PersonalDetail> PersonalDetails { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<BankInformation> BankInformations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Holiday> Holidays { get; set; }
    public DbSet<Qualification> Qualifications { get; set; }
    public DbSet<Salary> Salaries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        //TODO: Seed Data and create the first admin
    }

    //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    //{
    //    foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
    //    {
    //        switch (entry.State)
    //        {
    //            case EntityState.Added:
    //                entry.Entity.CreatedDate = DateTime.Now;
    //                entry.Entity.CreatedBy = _loggedInUserService.UserId;
    //                break;
    //            case EntityState.Modified:
    //                entry.Entity.LastModifiedDate = DateTime.Now;
    //                entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
    //                break;
    //        }
    //    }
    //    return base.SaveChangesAsync(cancellationToken);
    //}
}
