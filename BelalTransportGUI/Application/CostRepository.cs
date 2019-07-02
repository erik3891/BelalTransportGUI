using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Domain
{
    class CostRepository
    {
        public List<Cost> costs = new List<Cost>();
        public void AddCost(Cost cost)
        {
            costs.Add(cost);
        }
    }
}
