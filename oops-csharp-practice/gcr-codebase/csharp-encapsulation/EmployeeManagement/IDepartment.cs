using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EmployeeManagement
{
    interface IDepartment
    {
        void AssignDepartment(string dept);
        string GetDepartmentDetails();
    }
}
