using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace ListClassTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TakeInASizeInput_ChangeSizeOfArray_ReturnArraySize()
        {
            //arrange - arrange all necessary preconditions and inputs
            CustomList NewCustomList = new CustomList();
            int sizeInput = 0;
            int arraySize = 4;
            int expected = 0;
            int actual;

            //act - act on the method under test
            actual = NewCustomList.ChangeArraySize
 
            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckSizeOfArray_CountEachElementInArray_ReturnTheArrayCount()
        {

        }
        [TestMethod]
        public void CheckCountOfArray_CheckCapacityOfArray_ReturnTheArrayCapacity()
        {

        }
        [TestMethod]
        public void CheckSizeOfArray_ChangeSizeWhenCountIsCapacity_ReturnDoubleSizeArray()
        {

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
    }
}
