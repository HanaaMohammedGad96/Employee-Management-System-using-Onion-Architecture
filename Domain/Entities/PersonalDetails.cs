using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class PersonalDetail : AuditableEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthOfDate { get; set; }
    public Gender Gender { get; set; }
    public string Image { get; set; }
    public string NID { get; set; }
    public string Nationality { get; set; }
    public string Religion { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public int? NumberOfChild { get; set; }
}
