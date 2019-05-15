using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass2;

namespace CustomListTest2
{
    [TestClass]
    public class CustomListTest2
    {
        [TestMethod]
        public void TakeInASizeInput_ChangeSizeOfArray_ReturnArraySize()
        {
            //arrange - arrange all necessary preconditions and inputs
            CustomList2<int> NewCustomList = new CustomList2<int>();
            int sizeInput = 0;
            int arraySize = 4;
            int expected = 0;
            int actual;

            //act - act on the method under test

            //assert - assert that the expected result occured
            //Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods_ReturnArrayWithThem()
        {
            CustomList2<int> NewCustomList = new CustomList2<int>();
            int value1 = 7;
            int value2 = 5;
            int expected = 7;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.workingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods_ReturnArrayWithThem2()
        {
            CustomList2<int> NewCustomList = new CustomList2<int>();
            int value1 = 7;
            int value2 = 5;
            int expected = 5;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.workingArray[1];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethods_ReturnArrayWithoutThem()
        {
            CustomList2<int> NewCustomList = new CustomList2<int>();
            int value1 = 7;
            int value2 = 5;
            NewCustomList.workingArray[0] = value1;
            NewCustomList.workingArray[1] = value2;
            int expected = value1;
            int actual;

            //act - act on the method under test
            NewCustomList.Remove(value2);
            actual = NewCustomList.workingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
    }
}
