using Application.Features.Departments.Commands;
using Microsoft.AspNetCore.Mvc;
using WebApi.Config;

namespace WebApi.Controllers.v1._0._0
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ApiControllerBase
    {
        [HttpPost]
        public Task<ActionResult<int>> CreateDepartment([FromBody]CreateDepartmentCommand command, CancellationToken ct) 
            => Execute(command, ct);
    }
}
