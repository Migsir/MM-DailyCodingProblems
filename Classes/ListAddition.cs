using System;
using System.Collections.Generic;
using System.Linq;

/*
Good morning! Here's your coding interview problem for today.
This problem was recently asked by Google.
Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
*/

namespace DailyCode.classes
{
    public class ListAddition
    {

        private List<int> sumTotal;

        public ListAddition()
        {
            sumTotal = new List<int>();
        }

        private bool HasListValue(int value, List<int> intValues)
            => intValues?.Where(x => x == value).Count() > 0;
        public bool CanItBeSum(int value, List<int> intValues)
            => HasListValue(value, intValues) ? true : test(value, intValues?.OrderByDescending(x => x).ToList());

        public bool test(int lookingForValue, List<int> initValues)
        {
            var internalList = new List<int>();
            internalList.AddRange(initValues);
            sumTotal.AddRange(initValues);
            foreach (var currentValue in initValues)
            {
                internalList.RemoveAt(0);
                var sublist = new List<int>();
                internalList.ForEach(x => sublist.Add(x + currentValue));
                sumTotal.AddRange(sublist);
                SumEvaluation(internalList, sublist);
            }
            return sumTotal.Where(x => x == lookingForValue).Count() > 0;
        }

        public void SumEvaluation(List<int> vectorList, List<int> sublist)
        {
            var internalVectorList = new List<int>();
            internalVectorList.AddRange(vectorList);
            foreach (var currentValue in sublist)
            {
                internalVectorList?.RemoveAt(0);
                var internalSubList = new List<int>();
                internalVectorList.ForEach(x => internalSubList.Add(x + currentValue));
                sumTotal.AddRange(internalSubList);
                if (internalVectorList.Count > 0)
                {
                    SumEvaluation(internalVectorList, internalSubList);
                }
            }
        }

    }
}