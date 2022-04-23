using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public CoctailSort() { }
        public CoctailSort(IEnumerable<T> items) : base(items) { }   

        protected override void MakeSort()
        {

            var left = 0;
            var right = Items.Count - 1;

            while (left < right)
            {
                var swopCount = SwopCount;
                for (int i = left; i < right; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b) == 1)
                    {                       
                        Swop(i, i + 1);
                        CompareCount++;
                    }                                       
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    var a = Items[j];
                    var b = Items[j - 1];
                    if (a.CompareTo(b) == -1)
                    {                        
                        Swop(j, j - 1);
                        CompareCount++;
                    }                   
                }
                left++;

                if(swopCount == SwopCount)
                {
                    break;
                }
            }
        }
       
    }
}
