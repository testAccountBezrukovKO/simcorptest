using LinkedList.src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTests
{
    [TestClass]
    public class DoubleLinkedListTests
    {
        [TestMethod]
        public void DoubleLinkedListAddValues()
        {
            var keyExist = false;
            string valueToAdd = "1";
            var doubleLinkedList = new DoubleLinkedList<string>();
            doubleLinkedList.Add(valueToAdd);

            var listValues = doubleLinkedList.GetListValues();
            if (listValues != null && listValues.Count > 0)
            {
                keyExist = listValues.Contains(valueToAdd);
            }
            else
            {
                Assert.Fail("Add values test fails");
            }

            Assert.IsTrue(keyExist, "Value added to list successfully");
        }

        [TestMethod]
        public void DoubleLinkedListRemoveValues()
        {
            var keyExist = false;
            string valueToAdd = "1";
            string valueToRemove = "2";
            var doubleLinkedList = new DoubleLinkedList<string>();
            doubleLinkedList.Add(valueToAdd);
            doubleLinkedList.Add(valueToRemove);

            var listValues = doubleLinkedList.GetListValues();
            if (listValues != null && listValues.Count > 0)
            {
                keyExist = listValues.Contains(valueToRemove);
            }

            Assert.IsTrue(keyExist, "Value adding to list failed");

            doubleLinkedList.Remove(valueToRemove);

            listValues = doubleLinkedList.GetListValues();
            if (listValues != null && listValues.Count > 0)
            {
                keyExist = !listValues.Contains(valueToRemove);
            }
            else
            {
                Assert.Fail("Remove values test fails");
            }

            Assert.IsTrue(keyExist, "Value was not removed from list successfully");
        }

        [TestMethod]
        public void DoubleLinkedListGetNodeByValue()
        {
            string firstValueToAdd = "1";
            string secondValueToAdd = "2";
            string thirdValueToAdd = "3";
            var doubleLinkedList = new DoubleLinkedList<string>();
            doubleLinkedList.Add(firstValueToAdd);
            doubleLinkedList.Add(secondValueToAdd);
            doubleLinkedList.Add(thirdValueToAdd);

            var listNode = doubleLinkedList.GetNodeByValue(secondValueToAdd);
            if (listNode == null)
            {
                Assert.Fail($"{nameof(DoubleLinkedListGetNodeByValue)} method failed. Node is equals to null");
            }

            Assert.AreEqual(listNode.Data, secondValueToAdd, "Node data is incorrect");
        }

        [TestMethod]
        public void DoubleLinkedListGetItemsList()
        {
            var conditionSuccess = false;
            string firstValueToAdd = "1";
            string secondValueToAdd = "2";
            string thirdValueToAdd = "3";
            var singleLinkedList = new SingleLinkedList<string>();
            singleLinkedList.Add(firstValueToAdd);
            singleLinkedList.Add(secondValueToAdd);
            singleLinkedList.Add(thirdValueToAdd);

            var allValues = singleLinkedList.GetListValues();
            if (allValues == null)
            {
                Assert.Fail($"{nameof(DoubleLinkedListGetItemsList)} method failed. Node is equals to null");
            }

            if (allValues.Count == 3
                && allValues.Contains(firstValueToAdd)
                && allValues.Contains(secondValueToAdd)
                && allValues.Contains(thirdValueToAdd))
            {
                conditionSuccess = true;
            }

            Assert.IsTrue(conditionSuccess, "Get list items test failed");
        }
    }
}
