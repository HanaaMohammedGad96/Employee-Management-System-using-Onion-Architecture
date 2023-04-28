using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(e => e.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DepartmentId);

        builder.HasOne(e => e.Manager)
            .WithOne(e => e.Department)
            .HasForeignKey<Department>(e => e.ManagerId);
    }
}
