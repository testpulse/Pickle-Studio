using System.Collections.Generic;
using System.Linq;

namespace PickleStudio.TestData
{
    public class Calculator
    {
        public List<int> Numbers { get; private set; }

        public Calculator()
        {
            Numbers = new List<int>();
        }

        public int Add()
        {
            return Numbers.Sum();
        }
    }
}
