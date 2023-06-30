using Application.Contracts.Persistence;
using Application.Features.Employees.Models;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Employees.Queries;
public class GetEmployeeListQuery : IRequest<IList<EmployeeDto>>
{
    public class GetEmployeeListQueryHandler : IRequestHandler<GetEmployeeListQuery, IList<EmployeeDto>>
    {
        private readonly IAsyncRepository<EmployeeAccount> _employeeRepository;
        private readonly IMapper _mapper;

        public GetEmployeeListQueryHandler(IAsyncRepository<EmployeeAccount> employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper             = mapper;
        }
        public async Task<IList<EmployeeDto>> Handle(GetEmployeeListQuery request, CancellationToken ct)
        {
            var employees = await _employeeRepository.ListAllAsync();

            return _mapper.Map<IReadOnlyList<EmployeeAccount>, IList<EmployeeDto>>(employees);
        }
    }
}
