﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.ViewModel
{
    public class BinaryNumberConverter : INumberConverter
    {
        public string ToLocalString(int fromNumber)
        {
            return Convert.ToString(fromNumber, 2);
        }

        public int ToNumerical(string toNumber)
        {
            try
            {
                return Convert.ToInt32(toNumber, 2);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
