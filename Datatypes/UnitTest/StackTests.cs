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
    public class StackTests
    {
        [TestMethod]
        public void CanPush()
        {
            //ARRANGE
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);            
            //ACTION
            var last = stack.Pop();
            var secondLast = stack.Pop();
            //ASSERT
            Assert.IsTrue(((int)last) == 3);
            Assert.IsTrue(((int)secondLast) == 2);                
        }

    }
}
