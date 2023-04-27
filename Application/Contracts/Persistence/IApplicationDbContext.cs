using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts.Persistence;

public interface IApplicationDbContext
{
    DbSet<Department> Departments { get; set; }
}
