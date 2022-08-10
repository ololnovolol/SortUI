using System;
using Algorithm;
using System.Linq;
using System.Text;
using Algorithm.Structures;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass()]
    public class SortTest
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 3500; i++)
            {
                Items.Add(rnd.Next(0, 99));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubleTest()
        {
            //arange
            var bubble = new BubbleSort<int>();

            bubble.Items.AddRange(Items);

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionTest()
        {
            //arange
            var select = new SelectionSort<int>();

            select.Items.AddRange(Items);

            //act
            select.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], select.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            //arange
            var gnome = new GnomeSort<int>();

            gnome.Items.AddRange(Items);

            //act
            gnome.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }

        [TestMethod()]
        public void CoctailTest()
        {
            //arange
            var coctail = new BubbleSort<int>();

            coctail.Items.AddRange(Items);

            //act
            coctail.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], coctail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSort()
        {
            //arange
            var insert = new InsertSort<int>();

            insert.Items.AddRange(Items);

            //act
            insert.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSort()
        {
            //arange
            var shell = new ShellSort<int>();

            shell.Items.AddRange(Items);

            //act
            shell.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSort()
        {
            //arange
            var tree = new Tree<int>(Items);

            //act
            tree.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSort()
        {
            //arange
            var heap = new Tree<int>(Items);

            //act
            heap.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void LsdSortTest()
        {
            //arange
            var lsd = new LsdSort<int>();

            lsd.Items.AddRange(Items);

            //act
            lsd.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], lsd.Items[i]);
            }
        }

        [TestMethod()]
        public void MsdSortTest()
        {
            //arange
            var msd = new MsdSort<int>();

            msd.Items.AddRange(Items);

            //act
            msd.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], msd.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            //arange
            var merge = new MergeSort<int>();

            merge.Items.AddRange(Items);
            //act
            merge.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            //arange
            var quick = new QuickSort<int>();

            quick.Items.AddRange(Items);
            //act
            quick.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }








    }
}
