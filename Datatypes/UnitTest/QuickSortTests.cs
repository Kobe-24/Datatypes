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
    public class QuickSortTests
    {
        [TestMethod]
        public void CanSort()
        {
        //ARRANGE
        int[] numbers = new int[5] { 2, 1, 3, 5, 4};

        //ACTION
        QuickSort sorter = new QuickSort();
        var sortedNumbers = sorter.Sort(numbers);

        //ASSERT
        Assert.IsTrue(sortedNumbers[0] == 1);
        Assert.IsTrue(sortedNumbers[1] == 2);
        Assert.IsTrue(sortedNumbers[2] == 3);
        Assert.IsTrue(sortedNumbers[3] == 4);
        Assert.IsTrue(sortedNumbers[4] == 5);

        }
    }
}
