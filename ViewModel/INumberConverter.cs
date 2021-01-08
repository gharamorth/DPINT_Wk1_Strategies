﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.ViewModel
{
    public interface INumberConverter
    {
        string ToLocalString(int fromNumber);

        int ToNumerical(string toNumber);
    }
}
