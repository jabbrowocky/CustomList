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
        [TestMethod]
        public void Remove_DoMiddleIndecesShift_RemovingIndex()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "hi";
            string secondAddition = "you";
            string thirdAddition = "foo";
            string fourthAddition = "thru";
            // Act
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Add(thirdAddition);
            testList.Add(fourthAddition);
            testList.Remove(secondAddition);
            // Assert
            Assert.AreEqual(testList[1], thirdAddition);
        }
        [TestMethod]
        public void Remove_DoesArrayChangeSize_RemovingIndex()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "hi";
            string secondAddition = "you";
            string thirdAddition = "foo";
            string fourthAddition = "thru";
            // Act
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Add(thirdAddition);
            testList.Add(fourthAddition);
            testList.Remove(secondAddition);
            // Assert
            Assert.AreEqual(testList.Count, 3);

        }
        [TestMethod]
        public void Remove_DoesFalseValueFlag_NonexistantIndex()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "hi";
            string secondAddition = "you";
            string thirdAddition = "foo";
            string fourthAddition = "thru";
            string cheese = "cheese";
            bool arrayBool;
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Add(thirdAddition);
            testList.Add(fourthAddition);
            // Act
            arrayBool = testList.Remove(cheese);
            // Assert
            Assert.IsFalse(arrayBool);

        }
        [TestMethod]
        public void Remove_DoesCountRemainSame_ItemNotInIndex()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "hi";
            string secondAddition = "you";
            string thirdAddition = "foo";
            string fourthAddition = "thru";
            string cheese = "cheese";

            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Add(thirdAddition);
            testList.Add(fourthAddition);
            // Act
            testList.Remove(cheese);
            // Assert
            Assert.AreEqual(testList.Count, 4);


        }
        [TestMethod]
        public void Remove_TrueReturnOnSuccessfulRemoval_IndexPresentInArray()
        {
            // Arrange
            CustomList<string> testList = new CustomList<string>();
            string firstAddition = "hi";
            string secondAddition = "you";
            string thirdAddition = "foo";
            string fourthAddition = "thru";
            
            bool arrayBool;
            testList.Add(firstAddition);
            testList.Add(secondAddition);
            testList.Add(thirdAddition);
            testList.Add(fourthAddition);
            // Act
            arrayBool = testList.Remove(secondAddition);
            // Assert
            Assert.IsTrue(arrayBool);
        }
        //IEnumerable test
        [TestMethod]
        public void Ienumerable_DoesItForeach_ImplementForeachLoop ()
        {
            //Arrange
            CustomList<string> enumTest = new CustomList<string>() { "1", "2", "3" };
            CustomList<string> enumCompare = new CustomList<string>();
            //Act
            foreach (string element in enumTest)
            {
                enumCompare.Add(element);
            }
            //Assert
            Assert.AreEqual(enumTest[1], enumCompare[1]);
        }
        [TestMethod]
        public void Ienumerable_DoesItForeachObjects_TestingCount()
        {
            //Arrange
        
            CustomList <Test> testList = new CustomList<Test>() { new Test(), new Test(), new Test()};
            CustomList<Object> objectList = new CustomList<Object>();
            //Act
            foreach (Test element in testList)
            {
                
                objectList.Add(element);
            }
            //Assert
            Assert.IsTrue(objectList.Count == testList.Count);

        }
        [TestMethod]
        public void ToString_PositiveIntegers_StringEquivalencyResults()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3 };
            string stringResult = "1 2 3";
            string listString;
            //Act
            listString = testList.ToString();
            //Assert
            Assert.AreEqual(stringResult, listString);
        }
        [TestMethod]
        public void ToString_Bools_StringEquivalencyResults()
        {
            //Arrange
            bool isTrue = true;
            bool isFalse = false;
            CustomList<bool> testList = new CustomList<bool>() { isTrue, isFalse, isFalse};
            string stringResult = "True False False";
            string listString;
            //Act
            listString = testList.ToString();
            //Assert
            Assert.AreEqual(stringResult, listString);
        }
        [TestMethod]
        public void Contains_ListDoesNotContainString_ReturnsFalse()
        {
            //Arrange
            CustomList<string> pleaseWork = new CustomList<string>() { "hello", "world", "this", "exists" };
            string testWord = "chartreuse";
            bool result = false;
            //Act
            result = pleaseWork.Contains(testWord);
            //Assert
            Assert.IsFalse(result);
        }
        //Contains method tests
        [TestMethod]
        public void Contains_ListDoesNotContainInteger_ReturnsFalse()
        {
            //Arrange
            CustomList<int> listOfIntegers = new CustomList<int>() { 1, 2, 3, 4 };
            int testNumber = 27;
            bool result;
            //Act
            result = listOfIntegers.Contains(testNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Contains_ListContainsString_ReturnsTrue()
        {
            //Arrange
            CustomList<string> pleaseWork = new CustomList<string>() { "hello", "world", "this", "exists" };
            string testWord = "this";
            bool result = false;
            //Act
            result = pleaseWork.Contains(testWord);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Contains_ListContainsObject_ReturnsTrue()
        {
            Test testy = new Test();
            Test hopey = new Test();
            //Arrange
            CustomList<Test> objectList = new CustomList<Test>() {testy, hopey, testy };
            bool result = false;
            //Act
            result = objectList.Contains(hopey);
            //Assert
            Assert.IsTrue(result);
        }
        //overloaded + operator tests
        [TestMethod]
        public void PlusOperator_AddingIntList_ListContainsBothSetsOfInts()
        {
            //Arrange
            CustomList<int> firstHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> secondHalf = new CustomList<int>() { 4, 5, 6 };          
            CustomList<int> result = new CustomList<int>();
           
            //Act
            result = firstHalf + secondHalf;
            //Assert
            Assert.AreEqual(secondHalf[1], result[4]);
        }
        [TestMethod]
        public void PlusOperator_AddingStringList_ListContainsBothSetsOfStrings()
        {
            //Arrange
            CustomList<string> firstHalf = new CustomList<string>() { "hi", "world"};
            CustomList<string> secondHalf = new CustomList<string>() { "it's", "me", "margaret" };
          
            CustomList<string> result = new CustomList<string>();
           
            //Act
            result = firstHalf + secondHalf;

            //Assert
            Assert.AreEqual(secondHalf[2], result[4]);
        }
        //overloaded - operator tests
        [TestMethod]
        public void MinusOperator_SubtractingIntList_NewListContainsFirstListUnlikeValues()
        {
            //Arrange
            CustomList<int> firstHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> secondHalf = new CustomList<int>() { 1,2,6 };
            CustomList<int> result;
            //Act
            result = firstHalf - secondHalf;

            //Assert
            Assert.AreEqual(result[0], 3);
        }
        [TestMethod]
        public void MinusOperator_SubtractingIntList_NewListEmpty()
        {
            //Arrange
            CustomList<int> firstHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> secondHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> result;
            //Act
            result = firstHalf - secondHalf;

            //Assert
            Assert.IsTrue(result.Count==0);
        }
        //zip method tests
        [TestMethod]
        public void Zip_CombiningIntLists_NewListHasDuplicateValues()
        {
            //Arrange
            CustomList<int> firstHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> secondHalf = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> result;
            //Act
            result = firstHalf.Zip(secondHalf);

            //Assert
            Assert.IsTrue(result[1] == result[0]);
        }
        [TestMethod]
        public void Zip_CombiningStringLists_IndecesAlternate()
        {
            //Arrange
            CustomList<string> firstHalf = new CustomList<string>() { "Hello", "I'm", "what's" };
            CustomList<string> secondHalf = new CustomList<string>() { "world", "John", "up?" };
            CustomList<string> result;
            string sentence;
            //Act
            result = firstHalf.Zip(secondHalf);
            sentence = result.ToString();
            //Assert
            Assert.IsTrue(sentence == "Hello world I'm John what's up?");
        }
        [TestMethod]
        public void Zip_AlternateCombiningStringLists_IndecesAlternate()
        {
            //Arrange
            CustomList<string> firstHalf = new CustomList<string>() { "Hello ", "I'm ", "what's " };
            CustomList<string> secondHalf = new CustomList<string>() { "world ", "John ", "up?" };
            CustomList<string> result;
            string sentence="";
            //Act
            result = firstHalf.Zip(secondHalf);
            for (int i = 0; i < result.Count; i++)
            {
                sentence += result[i].ToString();
            }
            //Assert
            Assert.IsTrue(sentence == "Hello world I'm John what's up?");
        }
        
    }
}
