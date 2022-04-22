using System;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var left = 0;
            var right = Items.Count - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
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
                    }                   
                }
                left++;
            }
        }
       
    }
}
