using Domain.Common;

namespace Domain.Entities;

public class Holiday : AuditableEntity
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string EmpolyeeAccountId { get; set; }
    public virtual EmployeeAccount EmployeeAccount { get; set; }
}
