using Application.Features.Employees.Models;

namespace Application.Features.Departments.Models; 
public class DepartmentVm 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ManagerName { get; set; }
    public List<EmployeeDto> Employees { get; set; }
}
