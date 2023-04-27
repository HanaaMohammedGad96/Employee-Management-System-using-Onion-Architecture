using Domain.Common;

namespace Domain.Entities;

public class Attendance : AuditableEntity
{
    public int Id { get; set; } 
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string EmpolyeeAccountId { get; set; }
    public virtual EmployeeAccount EmployeeAccount { get; set; }
}
