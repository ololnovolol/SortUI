using System;
using Algorithm;
using System.Linq;
using System.Text;
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
            for (int i = 0; i < 2500; i++)
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








    }
}
