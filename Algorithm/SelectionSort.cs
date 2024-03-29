﻿using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public SelectionSort() { }
        public SelectionSort(IEnumerable<T> item) : base(item) { }


        protected override void MakeSort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                var currentIndex = i;
                var minimalIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
 
                    if (Compare(Items[minimalIndex],Items[j]) == 1)
                    {
                        minimalIndex = j;
                    }
                }

                if(currentIndex != minimalIndex)

                Swop(currentIndex, minimalIndex);
            }
        }
    }
}
