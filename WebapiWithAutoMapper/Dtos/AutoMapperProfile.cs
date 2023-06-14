using AutoMapper;
using WebapiWithAutoMapper.Models.Data.EmployeeDBContext;

namespace WebapiWithAutoMapper.Dtos
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>(); //map employee ppt to employeeDto ppt
            CreateMap<EmployeeDto, Employee>();
        }
    }
}
