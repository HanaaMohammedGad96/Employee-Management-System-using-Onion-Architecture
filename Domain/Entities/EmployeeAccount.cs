using Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class EmployeeAccount :  IdentityUser, IActive , IDelete
{
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }  

    public int PersonalDetailsId { get; set; }
    public virtual PersonalDetail PersonalDetails { get; set; }

    public int AddressId { get; set; }
    public virtual Address Address { get; set; } 

    public int DependantId { get; set; }
    public virtual Dependant Dependant { get; set; } 

    public int SalaryId { get; set; }
    public virtual Salary Salary { get; set; }

    public int BankInformationId { get; set; }
    public virtual BankInformation BankInformation { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }

    public virtual ICollection<Qualification> Qualifications { get; set; } = new HashSet<Qualification>();
    public virtual ICollection<Experience> Experiences { get; set; } = new HashSet<Experience>();
    public virtual ICollection<Attendance> Attendances { get; set; } = new HashSet<Attendance>();
    public virtual ICollection<Holiday> Holidays { get; set; } = new HashSet<Holiday>();
}
