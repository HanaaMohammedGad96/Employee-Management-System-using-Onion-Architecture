using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Departments.Commands;

public class CreateDepartmentCommand : IRequest<int>
{
    public string Name { get; set; }
    public string ManagerId { get; set; }

    public class  DepartmentValidator: AbstractValidator<CreateDepartmentCommand>
    {
        public DepartmentValidator()
        {
            RuleFor(p => p.Name)
             .NotEmpty().WithMessage("{PropertyName} is required.")
             .NotNull()
             .MaximumLength(50).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
        //TODO: ManagerId must exist validator
    }

    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IAsyncRepository<Department> _departmentRepository;
        private readonly IMapper _mapper;

        public CreateDepartmentCommandHandler(IAsyncRepository<Department> departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper               = mapper;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken ct)
        {
            var department = _mapper.Map<CreateDepartmentCommand, Department>(request);

            department = await _departmentRepository.AddAsync(department);

            return department.Id;
        }
    }

}
