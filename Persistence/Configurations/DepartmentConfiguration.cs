using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(e => e.Id);

        #region one-to-many relationship [each department has many employee]
         builder.HasMany(e => e.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region one-to-one relationship  [each department has on manager]
        builder.HasOne(e => e.Manager)
            .WithOne()
            .HasForeignKey<Department>(e => e.ManagerId)
           .OnDelete(DeleteBehavior.Restrict);
        #endregion
    }
}
