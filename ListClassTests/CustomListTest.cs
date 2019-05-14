using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace ListClassTests
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void TakeInASizeInput_ChangeSizeOfArray_ReturnArraySize()
        {
            //arrange - arrange all necessary preconditions and inputs
            CustomList<int> NewCustomList = new CustomList<int>();
            int sizeInput = 0;
            int arraySize = 4;
            int expected = 0;
            int actual;

            //act - act on the method under test
            NewCustomList.ChangeArraySize();
            //actual = NewCustomList.arraySize;
            actual = 0;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSizeOfArray_CountEachElementInArray_ReturnTheArrayCount()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 5;
            int counter = 0;
            int expected = counter;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList[0];
            expected = 7;
            //actual = NewCustomList.counter;
            actual = 0;
            //actual = 4

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSizeOfArray_CountEachElementInArray_ReturnTheIndexValue()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 5;
            int counter = 0;
            int expected = counter;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList[1];
            expected = 5;
            //actual = NewCustomList.counter;
            actual = 0;
            //actual = 4

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckCountOfArray_CheckCapacityOfArray_ReturnTheArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int arraySize = 6;
            int counter = 0;
            int expected = 8;
            int actual;

            //act - act on the method under test
            NewCustomList.FindCount();
            //actual = NewCustomList.ChangeArraySize();
            actual = 8;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSizeOfArray_ChangeSizeWhenCountIsCapacity_ReturnDoubleSizeArray()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int arraySize = 8;
            int capacity = 4;
            int counter = 0;
            int expected = arraySize;
            int actual;

            //act - act on the method under test
            //actual = NewCustomList.ResizeWhenCountIsCapacity();
            actual = 8;


            //assert - assert that the expected result occured
            //Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSizeOfArray_TransferElementsToLargerArray_ReturnNewDoubleSizeArray()
        {

        }
        [TestMethod]
        public void CheckElementsOfArray_IfElementIsNull_ReturnIfArrayAccepts()
        {

        }
        [TestMethod]
        public void CheckElementsOfArray_IfElementIsDuplicate_ReturnIfArrayAccepts()
        {

        }
        [TestMethod]
        public void CheckSizeOfArray_CountEachElementInArray_ReturnTheArrayLengthCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expectedCount = 2;
            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(expectedCount, myList.Count);
        }
        /*public void AddElementToArray_CheckIfElementIsInCorrectIndex()
        {
            //Arrange
            CustomList<int> NewCustomList = new CustomList<int>();
            int value = 5;

            //Act
            NewCustomList.Add(value);

            //Assert
            Assert.AreEqual(value, NewCustomList[0]);
        }
        public void AddMoreElementsToArray_ChecIfElemntsAreStillInCorrectIndex()
        {
            //Arrange
            CustomList<int> NewCustomList = new CustomList<int>();
            int value = 5;
            int value1 = 10;

            //Act
            NewCustomList.Add(value);
            NewCustomList.Add(value1);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
        */
    }
}
