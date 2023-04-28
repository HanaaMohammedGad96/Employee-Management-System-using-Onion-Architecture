using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts.Persistence;

public interface IApplicationDbContext 
{
    DbSet<EmployeeAccount> EmployeeAccounts { get; set; }
    DbSet<Dependant> Dependants { get; set; }
    DbSet<Department> Departments { get; set; }
    DbSet<PersonalDetail> PersonalDetails { get; set; }
    DbSet<Address> Addresses { get; set; }
    DbSet<Attendance> Attendances { get; set; }
    DbSet<BankInformation> BankInformations { get; set; }
    DbSet<Experience> Experiences { get; set; }
    DbSet<Holiday> Holidays { get; set; }
    DbSet<Qualification> Qualifications { get; set; }
    DbSet<Salary> Salaries { get; set; }
}
