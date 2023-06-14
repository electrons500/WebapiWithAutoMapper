using System;
using System.Collections.Generic;

namespace WebapiWithAutoMapper.Models.Data.EmployeeDBContext;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string City { get; set; } = null!;
}
