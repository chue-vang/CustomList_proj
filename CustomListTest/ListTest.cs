using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Add_AddIntToList_AddOneInt()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            int testNumber = 9;
            int expected = 9;
            int actual;

            //Act
            actual = testList.Add(testNumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddStringToList_AddOneString()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testString = "Testing string";
            string expected = testString;
            string actual;

            //Act
            actual = testList.Add(testString);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_DoubleCapacityOfArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_MultipleItemsToList_CountIncreasesByOne()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(1);
            testList.Add(2);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
