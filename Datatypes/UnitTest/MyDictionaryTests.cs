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
    public class MyDictionaryTests
    {
        [TestMethod]
        public void CanAdd()
        {
            //ARRANGE
            IMyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            //ACTION
            myDictionary.Add("Test", 1);
            //ASSERT
            Assert.IsTrue(myDictionary["Test"] == 1);            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),
        "bla bla")]
        public void CanNotAddSameKeyTwice()
        {
            //ARRANGE
            IMyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            //ACTION
            myDictionary.Add("Test", 1);
            myDictionary.Add("Test", 2);            
        }

        [TestMethod]
        public void CanContainsKey()
        {
            //ARRANGE
            IMyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            //ACTION
            myDictionary.Add("Test", 1);
            //ASSERT
            Assert.IsTrue(myDictionary.ContainsKey("Test"));
            Assert.IsTrue(myDictionary.ContainsKey("asdfsadf") == false);
        }

        [TestMethod]
        public void CanUseGetEnumerator()
        {
            //ARRANGE
            IMyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            //ACTION
            myDictionary.Add("Test", 1);
            myDictionary.Add("Test2", 2);
            myDictionary.Add("Test3", 3);

            int counter = 0;
            foreach (var kvp in myDictionary)
            {
                counter++;
            }
            //ASSERT
            Assert.IsTrue(counter == 3);            
        }

    }
}
