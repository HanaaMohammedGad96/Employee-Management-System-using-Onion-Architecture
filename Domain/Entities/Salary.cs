using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Salary : AuditableEntity
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public SalaryType Type { get; set; }
}
