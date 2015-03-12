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
    public class MergeSortTests
    {
        //[TestMethod]
        //public void CanSort()
        //{
        //    //ARRANGE
        //    int[] numbers = new int[5] { 2, 1, 3, 5, 4 };

        //    //ACTION
        //    var sorter = new MergeSort();
        //    var sortedNumbers = sorter.Sort(numbers);

        //    //ASSERT
        //    Assert.IsTrue(sortedNumbers[0] == 1);
        //    Assert.IsTrue(sortedNumbers[1] == 2);
        //    Assert.IsTrue(sortedNumbers[2] == 3);
        //    Assert.IsTrue(sortedNumbers[3] == 4);
        //    Assert.IsTrue(sortedNumbers[4] == 5);

        //}

        [TestMethod]
        public void CanMergeSortedList()
        {
            //ARRANGE
            List<int> sortedListA = new List<int> { 2, 5, 6 };
            List<int> sortedListB = new List<int> { 1, 3, 8 };

            //ACTION
            var sorter = new MergeSort();
            var sortedNumbers = sorter.MergeSortedList(sortedListA, sortedListB).ToList();

            //ASSERT
            CollectionAssert.AreEqual(new List<int> {1,2,3,5,6,8 }, sortedNumbers);            
        }
    }
}
