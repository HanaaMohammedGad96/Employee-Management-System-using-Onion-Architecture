using Domain.Common;

namespace Domain.Entities;

public class Experience :AuditableEntity
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string JobTitle { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string EmpolyeeAccountId { get; set; }
    public virtual EmployeeAccount EmployeeAccount { get; set; }
}
