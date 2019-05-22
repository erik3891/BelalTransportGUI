using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    public class Employee
    {
        public string EmployeeData
        {
            get;
            set;
        }
        public Employee(string employeedata)
        {
            EmployeeData = employeedata;
        }
    }
}
