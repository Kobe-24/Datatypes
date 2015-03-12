using Datatypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void CanChangeOrder()
        {
            //ARRANGE
            var linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            //ACTION
            linkedList.Reverse();
            //ASSERT
            Assert.IsTrue(((int)linkedList[0]) == 4);
            Assert.IsTrue(((int)linkedList[1]) == 3);
            Assert.IsTrue(((int)linkedList[2]) == 2);
            Assert.IsTrue(((int)linkedList[3]) == 1);         
        }

    }
}
