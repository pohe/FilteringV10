using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FilteringV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> values = new List<int>() {12, 24, 9, 10, 6, 3, 45};

            IFilterCondition below10= new FilterBelow10();

            //List<int> filteredValues = Filter.FilterValues(values, below10);
            List<int> filteredValues = Filter.FilterValues(values, new FilterBelow5ORAbove20());
            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }

            Console.WriteLine("Filtering with Predicate");

            Predicate<int> above40 = i => i > 40;
            
            List<int> filteredLambdaValues = Filter.FilterValues(values, above40);
            foreach (var value in filteredLambdaValues)
            {
                Console.Write($" {value} ");
            }

            Predicate<int> belowe10 = i => i < 10;
            List<int> filteredLambdaValues2 = Filter.FilterValues(values, belowe10);
            foreach (var value in filteredLambdaValues2)
            {
                Console.Write($" {value} ");
            }

            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}