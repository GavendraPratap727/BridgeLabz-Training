using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Encapsulation.EmployeeManagement
{
    class PartTimeEmployee:Employee
    {
        int hours;
        double rate;
        public PartTimeEmployee(int id, string name, int h, double r) : base(id, name, 0) {
            this.hours = h;
            this.rate = r;
        }
        public override double CalculateSalary()
        {
            return hours * rate;
        }

    }
}
