using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Dependant : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public Relation Relation { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
}
