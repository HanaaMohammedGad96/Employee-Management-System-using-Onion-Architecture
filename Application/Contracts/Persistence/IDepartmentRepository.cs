using Domain.Entities;

namespace Application.Contracts.Persistence;

public interface IDepartmentRepository : IAsyncRepository<Department>
{
    Task<List<Department>> GetDepartmentsWithManager(bool includePassedManagers);
}
