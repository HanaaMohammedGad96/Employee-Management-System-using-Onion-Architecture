using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeAccount>
{
    public void Configure(EntityTypeBuilder<EmployeeAccount> builder)
    {
        builder.HasKey(e => e.Id);

        #region one-to-many relationship [each employee work at a specific department]
           builder.HasOne(e => e.Department)
            .WithMany(e => e.Employees)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion
    }
}
