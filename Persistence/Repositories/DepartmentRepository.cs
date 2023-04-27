using Application.Contracts.Persistence;
using Domain.Entities;

namespace Persistence.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ApplicationDbContext context) : base(context)
    {
    }

    public Task<List<Department>> GetDepartmentsWithManagers(bool includePassedManagers)
    {
        //TODO: set your code
        throw new NotImplementedException();
    }
}
