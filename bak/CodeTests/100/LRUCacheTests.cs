using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class LRUCacheTests
    {
        [TestMethod()]
        public void LRUCacheTest()
        {
            LRUCache c = new LRUCache(2);
            c.Put(2, 1);
            c.Put(2, 2);
            Assert.AreEqual(2, c.Get(2));
            c.Put(1, 1);
            c.Put(4, 1);
            Assert.AreEqual(-1, c.Get(2));



            c = new LRUCache(2);
            c.Put(1, 1);
            c.Put(2, 2);
            Assert.AreEqual(1, c.Get(1));
            c.Put(3, 3);
            Assert.AreEqual(-1, c.Get(2));
            c.Put(4, 4);
            Assert.AreEqual(-1, c.Get(1));
            Assert.AreEqual(3, c.Get(3));
            Assert.AreEqual(4, c.Get(4));


            c = new LRUCache(2);
            c.Put(2, 1);
            c.Put(1, 2);
            c.Put(2, 3);
            c.Put(4, 1);
            Assert.AreEqual(-1, c.Get(1));
            Assert.AreEqual(3, c.Get(2));

        }
    }
}