using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyListClass;

namespace MyListTests
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

            //assert - assert that the expected result occured
            //Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods_ReturnArrayWithThem()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 7;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            actual = NewCustomList.workingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods2_ReturnArrayWithThem2()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
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
        public void HaveArrayWithoutElementsOnIt_UseAddMethods4_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 5;
            int expected = 8;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods8_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 5;
            int expected = 16;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods16_ReturnArrayCapacity()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = 32;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 17; i++)
            {
                NewCustomList.Add(value1);
            }
            
            actual = NewCustomList.Capacity;

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithoutElementsOnIt_UseAddMethods16_ReturnArrayIndexAt17()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int value2 = 20;
            int expected = value2;
            int actual;

            //act - act on the method under test
            for (int i = 0; i < 17; i++)
            {
                NewCustomList.Add(value1);
            }
            NewCustomList.Add(value2);

            actual = NewCustomList.workingArray[17];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseRemoveMethods_ReturnArrayWithoutThem()
        {
            CustomList<int> NewCustomList = new CustomList<int>();
            int value1 = 7;
            int expected = value1;
            int actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            //NewCustomList.Remove(value1);
            actual = NewCustomList.workingArray[0];

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HaveArrayWithElementsOnIt_UseToStringMethod_ReturnStringOfElements()
        {
            CustomList<string> NewCustomList = new CustomList<string>();
            string value1 = "Hello";
            string value2= "Bob";
            string expected = "Hello Bob";
            string actual;

            //act - act on the method under test
            NewCustomList.Add(value1);
            NewCustomList.Add(value2);
            actual = NewCustomList.ToString();

            //assert - assert that the expected result occured
            Assert.AreEqual(expected, actual);
        }
    }
}
