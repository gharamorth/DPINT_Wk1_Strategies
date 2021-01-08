using DPINT_Wk1_Strategies.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies
{
    public class NumberConverterFactory
    {
        private Dictionary<string, INumberConverter> _converters;

        public IEnumerable<string> ConverterNames
        {
            get
            {
                return _converters.Keys;
            }
        }

        public NumberConverterFactory()
        {
            _converters = new Dictionary<string, INumberConverter>
            {
                { "Binary", new BinaryNumberConverter() },
                { "Hexadecimal", new HexadecimalNumberConverter() },
                { "Numerical", new NumericalNumberConverter() },
                { "Roman", new RomanNumberConverter() },
                { "Octal", new OctalNumberConverter()},
            };
        }

        public INumberConverter GetConverter(string name)
        {
            return _converters[name];
        }

    }
}
