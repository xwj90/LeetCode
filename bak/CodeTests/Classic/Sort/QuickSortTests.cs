using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Classic.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests;

namespace Code.Classic.Sort.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void QuickSort_Test()
        {
            var a = ArrayHelper.RandomGenerate(10000);
            var r = QuickSort.Sort(a);
            Array.Sort(a);
            Assert.IsTrue(r.AssertCheckInOrder(a));
        }
    }
}