﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI.Domain
{
    public class Income
    {
        int Amount { get; set; }
        public Income(int amount)
        {
            Amount = amount;
        }
    }
}
