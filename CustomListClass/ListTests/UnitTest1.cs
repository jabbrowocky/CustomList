using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace ListTests
{
    [TestClass]
    public class UnitTest1
    {
        // .Add() tests
        [TestMethod]
        public void Add_DoesItAdd_ContainsAddition()
        {
            // Arrange
            // value to add to array
            int numberToAdd = 5;
            CustomList<int> testList = new CustomList<int>();
            // Act
            // test add function
            testList.Add(numberToAdd);
            // Assert
            // does the array contain addition?
            Assert.AreEqual(testList[0], numberToAdd);
        }
        [TestMethod]
        public void Add_DoesCountIncrease_CountIsCorrect()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string countMattersHere = "whatever";
            // Act
            testList.Add(countMattersHere);
            // Assert
            Assert.AreEqual(testList.Count, 1);

        }
        [TestMethod]
        public void Add_DoesCountIncreaseWithMultipleAdditions_CountIsCorrect()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int fourthNumber = 4;
            //Act
            testList.Add(firstNumber);
            testList.Add(secondNumber);
            testList.Add(thirdNumber);
            testList.Add(fourthNumber);

            //Assert
            Assert.IsTrue(testList.Count == 4);
        }
       
        [TestMethod]
        public void Add_DoIndecesContainProperValues_SecondWordCheck()
        {

            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstWord = "Hello";
            string secondWord = "World";

            //Act
            testList.Add(firstWord);
            testList.Add(secondWord);
            //Assert
            Assert.AreEqual(testList[1], "World");
        }
        [TestMethod]
        public void Add_DoIndecesContainProperValues_MiddleValueCheck()
        {

            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstWord = "Hello";
            string secondWord = "This";
            string thirdWord = "George";

            //Act
            testList.Add(firstWord);
            testList.Add(secondWord);
            testList.Add(thirdWord);
            //Assert
            Assert.AreEqual(testList[1], "This");
        }
        [TestMethod]
        public void Add_DoesListSizeShift_AddingSixValues()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 5;
            int fourthNumber = 3;
            int fifthNumber = 7;
            int sixthNumber = 25;

            // Act 
            testList.Add(firstNumber);
            testList.Add(secondNumber);
            testList.Add(thirdNumber);
            testList.Add(fourthNumber);
            testList.Add(fifthNumber);
            testList.Add(sixthNumber);
            // Assert
            Assert.AreEqual(testList[5], 25);
        }
        [TestMethod]
        public void Add_DoesCountMatch_AddingSixValues()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 5;
            int fourthNumber = 3;
            int fifthNumber = 7;
            int sixthNumber = 25;

            // Act 
            testList.Add(firstNumber);
            testList.Add(secondNumber);
            testList.Add(thirdNumber);
            testList.Add(fourthNumber);
            testList.Add(fifthNumber);
            testList.Add(sixthNumber);
            // Assert
            Assert.AreEqual(testList.Count, 6);
        }
        //.Remove() tests
        [TestMethod]
        public void Remove_DoesIndexMatch_RemovingAValue()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "word one";
            string secondAddition = "word two";

            // Act
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Remove(firstAddition);
            // Assert
            Assert.AreEqual(testList[0], secondAddition);
        }
        [TestMethod]
        public void Remove_DoesCountDecrease_RemovingAnIndex()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "word one";
            string secondAddition = "word two";
            //Act
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Remove(firstAddition);
            //Assert
            Assert.AreEqual(testList.Count, 1);
        }        
    }
}
