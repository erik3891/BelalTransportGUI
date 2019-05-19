using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    public class Employee
    {
        public Employee(string cpr, string employeefirstname, string employeelastname)
        {
                CPR = cpr;
                EmployeeFirstName = employeefirstname;
                EmployeeLastName = employeelastname;
        }

            public string CPR { get; set; }
            public string EmployeeFirstName { get; set; }
            public string EmployeeLastName { get; set; }
    }
}
