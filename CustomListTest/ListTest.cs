using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    //Unit test Add method
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Add_AddIntToList_CheckZeroIndex()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            int testNumber = 1;
            int expected = 1;
            int actual;            

            //Act
            testList.Add(testNumber);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddStringToList_CheckZeroIndex()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testString = "Testing string";
            string expected = testString;
            string actual;

            //Act
            testList.Add(testString);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_CapacityOfArray()
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
        public void Add_MultipleItemsToList_CountIncreasesByThatNumber()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //after capacity is increased, make sure one of the previous indexes is still the same
        [TestMethod]
        public void Add_AddItemsToFullArray_VerifyingItemsCopiedOver()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int expected4 = 5;
            int actual0;
            int actual1;
            int actual2;
            int actual3;
            int actual4;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual0 = testList[0];
            actual1 = testList[1];
            actual2 = testList[2];
            actual3 = testList[3];
            actual4 = testList[4];

            //Assert
            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        //Unit test Remove method
        [TestMethod]
        public void Remove_RemoveIntFromList_CheckZeroIndex()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testNumber = 1;
            int expected = 0;
            int actual;

            //Act
            testList.Add(testNumber);
            testList.Remove(testNumber);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveStringFromList_CheckZeroIndex()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testString = "Testing string";
            string expected = null;
            string actual;

            //Act
            testList.Add(testString);
            testList.Remove(testString);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOneInt_VerifyCountAfterRemove()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int testNumberOne = 1;
            int testNumberTwo = 2;
            int testNumberThree = 3;
            int expected = 2;
            int actual;

            //Act
            testList.Add(testNumberOne);
            testList.Add(testNumberTwo);
            testList.Add(testNumberThree);
            testList.Remove(testNumberOne);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValueIndex_ShiftValueIndex()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFour = 4;
            int numberFive = 5;
            int expected = 4;
            int actual;

            //Act
            testList.Add(numberOne);
            testList.Add(numberTwo);
            testList.Add(numberThree);
            testList.Add(numberFour);
            testList.Add(numberFive);
            testList.Remove(numberOne);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Unit test ToString method
        [TestMethod]
        public void ToString_ConvertStringValue_VerifyItemConverted_ToString()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "1";
            string actual;

            //Act
            testList.Add(1);
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_MultipleValues_VerifyMultipleItemsConverted_ToString()
        {
            //Arange
            CustomList<int> testList = new CustomList<int>();
            string expected = "123456789";
            string actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            actual = testList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Unit test +Operator
        [TestMethod]
        public void OverloadPlusOperator_AddThreeItemsFromEachList_CountIsSix()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>();
            CustomList<int> customListTwo = new CustomList<int>();
            int expected = 6;
            int actual;

            //Act
            customListOne.Add(1);
            customListOne.Add(3);
            customListOne.Add(5);
            customListTwo.Add(2);
            customListTwo.Add(4);
            customListTwo.Add(6);

            CustomList<int> result = customListOne + customListTwo;            
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadPlusOperator_AddEmptyLists_CreateEmptyList()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>();
            CustomList<int> customListTwo = new CustomList<int>();

            //Act
            CustomList<int> result = customListOne + customListTwo;

            //Assert
            Assert.AreEqual(0, result.Count);
        }

        //Unit test -Operator
        [TestMethod]
        public void OverloadMinusOperator_DifferenceOfTwoCustomLists_CountIsTwo()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>();
            CustomList<int> customListTwo = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            customListOne.Add(1);
            customListOne.Add(3);
            customListOne.Add(5);            
            customListTwo.Add(2);
            customListTwo.Add(1);
            customListTwo.Add(6);

            CustomList<int> result = customListOne - customListTwo;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //Unit test Zip method
        //[TestMethod]
        //public void Zip_BothListsCountAreEqual_ListCountIsSix()
        //{
        //    //Arrange
        //    CustomList<int> customListOne = new CustomList<int>();
        //    CustomList<int> customListTwo = new CustomList<int>();
        //    int expected = 6;
        //    int actual;

        //    //Act
        //    customListOne.Add(1);
        //    customListOne.Add(3);
        //    customListOne.Add(5);
        //    customListTwo.Add(2);
        //    customListTwo.Add(4);
        //    customListTwo.Add(6);

        //    CustomList<int> result = customListOne.Zip(customListTwo);
        //    actual = result.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
