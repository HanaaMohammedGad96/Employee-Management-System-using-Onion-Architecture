using Application.Contracts.Persistence;
using Application.Features.Departments.Models;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Departments.Queries; 
public class GetDepartmentsListQuery : IRequest<IList<DepartmentVm>>
{
    public bool includePassedManagers { get; set; }
    public class GetDepartmentQueryHandler : IRequestHandler<GetDepartmentsListQuery, IList<DepartmentVm>>
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public GetDepartmentQueryHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper               = mapper;
        }
        public async Task<IList<DepartmentVm>> Handle(GetDepartmentsListQuery request, CancellationToken cancellationToken)
        {
            var departments = await _departmentRepository.GetDepartmentsWithManager(request.includePassedManagers);

            return _mapper.Map<IReadOnlyList<Department>, IList<DepartmentVm>>(departments);
        }
    }
}
