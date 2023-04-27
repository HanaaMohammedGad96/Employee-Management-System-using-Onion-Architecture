using Domain.Common;

namespace Domain.Entities;

public class BankInformation : AuditableEntity , IDelete
{
    public int Id { get; set; }
    public string BankName { get; set; }
    public string BankAccountNumber { get; set; }
    public bool IsDeleted { get; set; }
}
