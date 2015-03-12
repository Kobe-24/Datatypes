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
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void CanAddPrint()
        {
            // ARRANGE
            var myTree = new BinarySearchTree<int>();
            // ACTION
            myTree.Add(2);
            myTree.Add(1);
            myTree.Add(3);
            
            // ASSERT
            Assert.AreEqual("1;2;3;", myTree.PrintTreeInOrder());
        }

        [TestMethod]
        public void CanAddDeletePrint()
        {
            // ARRANGE
            var myTree = new BinarySearchTree<int>();
            // ACTION
            myTree.Add(2);
            myTree.Add(1);
            myTree.Add(3);
            myTree.Add(4);
            myTree.Delete(4);

            // ASSERT
            Assert.AreEqual("1;2;3;", myTree.PrintTreeInOrder());


        }

    }
}
