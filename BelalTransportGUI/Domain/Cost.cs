using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Domain
{
    public class GetSum
    {
        private List<int> costs = new List<int>();
            
        public void AddCost(int cost)
        {
            costs.Add(cost);
        }

        public static GetSum(string employeedata)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmployeeData == employeedata)
                {
                    return employees[i];
                }
            }
            return null;
        }
        public static int Sum2 (int costs)
        {
            return costs.Sum(x => Convert.ToInt32(x)));
        }
    }
}
