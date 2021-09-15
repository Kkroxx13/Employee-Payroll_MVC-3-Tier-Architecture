using CommonLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IEmployeeBL
    {
        List<Employee> EmployeeList();
        bool InsertEmployee(Parent employee);

        bool DeleteEmployee(Parent employee);

        string RegisterUser(UserDetails user);

        string ValidateLogin(UserDetails user);
    }
}
