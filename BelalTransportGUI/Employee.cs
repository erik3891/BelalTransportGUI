using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    class Employee
    {
        public Employee(string cpr, string medarbejderfornavn, string medarbejderefternavn)
        {
                CPR = cpr;
                MedarbejderFornavn = medarbejderfornavn;
                MedarbejderEfternavn = medarbejderefternavn;
        }

            public string CPR { get; set; }
            public string MedarbejderFornavn { get; set; }
            public string MedarbejderEfternavn { get; set; }
    }
}
