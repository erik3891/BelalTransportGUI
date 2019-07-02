using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Domain
{
    class IncomeRepository
    {
        public List<Income> incomes = new List<Income>();
        public void AddIncome(Income income)
        {
            incomes.Add(income);
        }
    }
}
