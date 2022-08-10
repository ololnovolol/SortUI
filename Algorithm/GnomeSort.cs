using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithm
{
    public class GnomeSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public GnomeSort() { }

        public GnomeSort(IEnumerable<T> item) : base(item) { }

        protected override void MakeSort()
        {
            //SortUp();
            SortGnom();
        }

        private void SortUp()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                var firtstItem = Items[i];
                var SecondItem = Items[i + 1];

                if (Compare(firtstItem, SecondItem) == 1)
                {
                    Swop(i, i + 1);

                    if(i >= 1 && Compare(Items[i - 1],Items[i]) == 1)
                    {
                        SortDown(i);
                    }                  
                }
            }
        }
        private void SortDown(int firstIndex)
        {
            if(firstIndex == 0)
            {
                SortUp();
            }

            for (int i = firstIndex; i > 0; i--)
            {
                var lasttItem = Items[i];
                var pre_LastItem = Items[i - 1];

                if (Compare(pre_LastItem,lasttItem) == 1)
                {
                    Swop(i, i - 1);
                }
                else
                {
                    break;
                }
            }

            if(firstIndex != Items.Count)
            {
                SortUp();
            }
            
        }

        private void SortGnom()
        {
            int counter = 1;
            while ( counter < Items.Count)
            {
                if (counter == 0 || Compare(Items[counter],Items[counter - 1]) != -1)
                {
                    counter++;
                }
                else
                {
                    Swop(counter, counter - 1);
                    counter--;
                }
            }
        }

    }
}
