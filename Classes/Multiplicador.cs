using System;
using System.Collections.Generic;
using System.Linq;

/*
This problem was asked by Uber.
Given an array of integers, 
return a new array such that each element at index [i] of the new array is the product of all the numbers in the original array except the one at [i].

For example, if our input was [1, 2, 3, 4, 5], 
the expected output would be [120, 60, 40, 30, 24]. 

If our input was [3, 2, 1], the expected output would be [2, 3, 6].
*/

namespace DailyCode.classes
{
    public class Multiplicar
    {
        /// <summary>
        /// Get or Set the list of numbers Provided
        /// </summary>
        private List<int> _providedNumbers;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="numbers">List of numbers provided</param>
        public Multiplicar(List<int> numbers)
        {
            _providedNumbers = numbers;
        }

        public List<int> CreateResultList()
        {   var _newlist = new List<int>();
            for(var i =0; i < _providedNumbers.Count; i++)
            {
                var totalBefore = 1; 
                var totalAfter = 1;
                var beforeCurrentIndex = _providedNumbers.GetRange(0,i);
                var afterCurrentIndex  = _providedNumbers.GetRange((i+1 == _providedNumbers.Count ? i : i+1), (_providedNumbers.Count - (i+1)));
                beforeCurrentIndex.ForEach( x => totalBefore *= x );
                afterCurrentIndex .ForEach( x => totalAfter  *= x );
                _newlist.Add(totalAfter * totalBefore);
            }
            return _newlist;
        }

        public override string ToString() => $"[{string.Join(",", CreateResultList())}]";

    }

}