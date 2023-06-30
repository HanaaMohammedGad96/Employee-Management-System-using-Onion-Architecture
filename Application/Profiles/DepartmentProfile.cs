using Application.Features.Departments.Commands;
using Application.Features.Departments.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Profiles;

public class DepartmentProfile   : Profile
{
	public DepartmentProfile()
	{
		CreateMap<Department, DepartmentVm>().ReverseMap();
		CreateMap<Department, CreateDepartmentCommand>().ReverseMap();
	}
}
