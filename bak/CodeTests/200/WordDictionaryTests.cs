using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class WordDictionaryTests
    {
        [TestMethod()]
        public void WordDictionaryTest()
        {
           // throw new NotImplementedException();
            WordDictionary d = new WordDictionary();
            d.AddWord("bad");
            d.AddWord("dad");
            d.AddWord("mad");
            Assert.AreEqual(false, d.Search("pad"));
            Assert.AreEqual(true, d.Search("bad"));
            Assert.AreEqual(true, d.Search(".ad"));
            Assert.AreEqual(true, d.Search("b.."));

            d = new WordDictionary();
            d.AddWord("a");
            d.AddWord("a");
            Assert.AreEqual(true, d.Search("."));
            Assert.AreEqual(true, d.Search("a"));
            Assert.AreEqual(false, d.Search("aa"));
            Assert.AreEqual(true, d.Search("a"));
            Assert.AreEqual(false, d.Search(".a"));
            Assert.AreEqual(false, d.Search("a."));


            d = new WordDictionary();
            d.AddWord("at");
            d.AddWord("and");
            d.AddWord("an");
            Assert.AreEqual(false, d.Search("."));
            Assert.AreEqual(false, d.Search("a"));
            Assert.AreEqual(false, d.Search("aa"));
            Assert.AreEqual(false, d.Search("a"));
            Assert.AreEqual(false, d.Search(".a"));
            Assert.AreEqual(true, d.Search("a."));
        }
    }
}