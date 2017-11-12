using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MinStackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Assert.AreEqual(-3, minStack.GetMin());
            minStack.Pop();
            Assert.AreEqual(0, minStack.Top());
            Assert.AreEqual(-2, minStack.GetMin());
        }
    }
}