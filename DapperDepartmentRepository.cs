using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperInClass
{
    public class DapperDepartmentRepository : IDepartmentRespository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }
    }
}

