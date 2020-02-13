using System;
using System.Collections.Generic;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, IFilterCondition filterCon)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                //if (value > 10)
                if (filterCon.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }

        public static List<int> FilterValues(List<int> values, Predicate<int> filterFunc)
        {
            List<int> filteredValues = new List<int>();

            foreach (int value in values)
            {
                
                if (filterFunc(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
    }
}