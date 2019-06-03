using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    public class EmployeePaycheck
    {
        string Lastname { get; set; }
        string Firstname { get; set;}
        string CPR { get; set;}
        string Deduction { get; set; }
        public EmployeePaycheck(string cpr, string firstname, string lastname,string deduction)
        {
            CPR = cpr;
            Firstname = firstname;
            Lastname = lastname;
            Deduction = deduction;
        }
    }
}
