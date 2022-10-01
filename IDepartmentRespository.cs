using System;
using System.Collections.Generic;

namespace DapperInClass
{
    public interface IDepartmentRespository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}

