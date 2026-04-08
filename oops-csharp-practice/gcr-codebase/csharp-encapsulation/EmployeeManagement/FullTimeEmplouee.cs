using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EmployeeManagement
{
     class FullTimeEmplouee:Employee
    {
        public FullTimeEmplouee(int id,string name,double salary):base(id,name ,salary ){}
        public override double CalculateSalary()
        {
            return baseSalary;
        }

    }
}
