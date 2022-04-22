using System;
using Algorithm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
             [TestMethod()]
        public void SortTest()
        {
            //arange
            var coctail = new CoctailSort<int>();

            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            coctail.Items.AddRange(items);
            items.Sort();

            //act
            coctail.Sort();

            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], coctail.Items[i]);
            }
        

        }
    }
}