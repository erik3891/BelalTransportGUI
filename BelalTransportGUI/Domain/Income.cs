using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Domain
{
    public class Income
    {
        private List<int> incomes = new List<int>();
        public void AddIncome(int income)
        {
            incomes.Add(income);
        }

    }
}
