using System;
using System.Collections.Generic;

namespace Algorithm
{   
    public class InsertSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public InsertSort() { }
        public InsertSort(IEnumerable<T> items) : base(items) { }

        protected override void MakeSort()
        {
            
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var counterr = i;
                while(counterr > 0 && Compare(temp, Items[counterr -1]) == -1)
                {

                    Swop(counterr, counterr - 1);
                    counterr--;

                }
                Items[counterr] = temp;
            }
        }
    }
}
