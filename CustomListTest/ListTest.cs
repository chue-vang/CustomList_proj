using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Add_StringToList_AddingOneString()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testString = "Testing string";

            //Act
            testList.Add(testString);

            //Assert
            Assert.AreEqual(testString, testList[0]);
        }
    }

    [TestMethod]
    public void Add_IntToList_AddOneInt()
    {
        //Arrange
        CustomList<int> testList = new CustomList<int>;
        int number = 3;
        int expected = 3;

        //Act
        testList.Add(number);

        //Assert
        Assert.AreEqual(expected, number[0]);
    }

    [TestMethod]
    public void Add_MultipleIntToList_AddThreeInt()
    {
        //Arange
        CustomList<int> testList = new CustomList<int>() { 1, 2, 3 };
        int expected = 3;

        //Act


        //Assert
        Assert.AreEqual(expected, testList[2]);
    }
}
