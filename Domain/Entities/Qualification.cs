using Domain.Common;

namespace Domain.Entities;

public class Qualification : AuditableEntity
{
    public int Id { get; set; }
    public string Institustion { get; set; }
    public string Speciality { get; set; }
    public string Degree { get; set; }
    public float Grade { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public string EmpolyeeAccountId { get; set; }
    public virtual EmployeeAccount EmployeeAccount { get; set; }
}
