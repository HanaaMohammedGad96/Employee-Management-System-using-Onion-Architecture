using Domain.Common;

namespace Domain.Entities;

public class Department : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ManagerId { get; set; }
    public virtual EmployeeAccount Manager { get; set; }
    public virtual ICollection<EmployeeAccount> Employees { get; set; } = new HashSet<EmployeeAccount>();
}
