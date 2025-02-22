using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _testList;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _testList = new List<int>();
        }

        [Test]
        public void AddElement_ShouldIncreaseSize()
        {
            _listManager.AddElement(_testList, 5);
            Assert.Contains(5, _testList);
            Assert.AreEqual(1, _testList.Count);
        }

        [Test]
        public void RemoveElement_ShouldDecreaseSize()
        {
            _listManager.AddElement(_testList, 10);
            _listManager.RemoveElement(_testList, 10);
            Assert.IsFalse(_testList.Contains(10));
            Assert.AreEqual(0, _testList.Count);
        }

        [Test]
        public void GetSize_ShouldReturnCorrectSize()
        {
            _listManager.AddElement(_testList, 1);
            _listManager.AddElement(_testList, 2);
            Assert.AreEqual(2, _listManager.GetSize(_testList));
        }
    }

}
