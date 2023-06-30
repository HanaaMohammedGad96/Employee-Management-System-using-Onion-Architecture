using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<List<Department>> GetDepartmentsWithManager(bool includePassedManagers)
    {
        var query = _context.Departments.AsNoTracking();

        if (includePassedManagers)
            query = query.Include(e => e.Manager);

        return await query.ToListAsync();
    }
}
