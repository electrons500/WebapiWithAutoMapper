using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebapiWithAutoMapper.Dtos;
using WebapiWithAutoMapper.Models.Data.EmployeeDBContext;

namespace WebapiWithAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly EmployeeDbContext _Ctx;
        public EmployeeController(IMapper mapper, EmployeeDbContext ctx)
        {
            _Mapper = mapper;
            _Ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
           List<Employee> employees = _Ctx.Employees.ToList();
            var model = employees.Select(x => _Mapper.Map<EmployeeDto>(x));
            return Ok(model);
        }

        [HttpPost]
        public IActionResult AddEmployees(EmployeeDto dto)
        {
           var employee = _Mapper.Map<Employee>(dto);
            _Ctx.Employees.Add(employee);
            _Ctx.SaveChanges();

            return Ok();
        }



    }
}
