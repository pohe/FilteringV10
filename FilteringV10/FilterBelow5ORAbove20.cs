using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringV10
{
    public class FilterBelow5ORAbove20: IFilterCondition
    {
        public bool Condition(int value)
        {
            return value < 5 || value > 20;
        }
    }
}
