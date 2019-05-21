using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    public class Employee
    {
        public Employee(string fullemployee)
        {
                FullEmployee = fullemployee;
        }
            
        public string FullEmployee { get; set; }
        //    public string CPR { get; set; }
        //    public string EmployeeFirstName { get; set; }
        //    public string EmployeeLastName { get; set; }

        //public override string ToString()
        //{
        //    return CPR + EmployeeFirstName + EmployeeLastName;
        //}
    }
}
