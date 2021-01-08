using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.ViewModel
{
    public class NumericalNumberConverter : INumberConverter
    {
        public string ToLocalString(int fromNumber)
        {
            return fromNumber.ToString();
        }

        public int ToNumerical(string toNumber)
        {
            return Int32.Parse(toNumber);
        }
    }
}
