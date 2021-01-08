using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.ViewModel
{
    public class OctalNumberConverter : INumberConverter
    {
        public string ToLocalString(int fromNumber)
        {
            return Convert.ToString(fromNumber, 8);
        }

        public int ToNumerical(string toNumber)
        {
            return Convert.ToInt32(toNumber, 8);
        }
    }
}
