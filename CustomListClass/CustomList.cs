using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList
    {
        //has these
        public int[] array;

        //constructor
        public CustomList()
        {
            array = new int[0];
        }

        //does this
        public void ChangeArraySize()
        {

        }
        public void AcceptNullAsValid()
        {

        }
        public void AllowDuplicateElements()
        {

        }
        public void FindCount()
        {
            //Gets the number of elements contained in the List<T>.
        }
        public void FindCapacity()
        {
            /*Gets or sets the total number of elements the internal data structure can hold without resizing.*/
        }
        public void ResizeWhenCountIsCapacity()
        {
            /*If the Count becomes equals to Capacity, then the capacity of the List increased automatically 
             * by reallocating the internal array. The existing elements will be copied to the new array before the 
             * addition of the new element.
            */
        }
    }
}
/*[TestMethod]
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
        */


