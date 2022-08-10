﻿using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class LsdSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LsdSort(IEnumerable<T> items) : base(items) { }

        public LsdSort() { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength();

            for (int step = 0; step < length; step++)
            {
                // Распределение элементов по корзинам. 
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                var j = 0;
                // Сборка элементов.
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Set(j, item);
                        j++;
                    }
                }

                // Очистка корзин.
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            int length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только целые числа (больше либо равно нуля)", nameof(Items));
                }

                //var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); // Не работает со значением item = 0. Дает -inf.
                var l = item.GetHashCode().ToString().Length;
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
