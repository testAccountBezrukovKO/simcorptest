using System.Collections.Generic;

namespace LinkedList.src
{
    public class SingleLinkedList<T> 
    {        
        private Node<T> head;

        /// <summary>
        /// Add new item to the list
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            var newNode = new Node<T>(item);
            if (this.head == null)
            {
                this.head = newNode;
                return;
            }

            Node<T> lastNode = GetLastNode(this);
            lastNode.next = newNode;
        }

        /// <summary>
        /// Get node by its value
        /// </summary>
        /// <param name="data">Value for comparison</param>
        /// <returns>Node that contains incoming value</returns>
        public Node<T> GetNodeByValue(T data)
        {
            if (data != null)
            {
                Node<T> current = head;

                while (current != null)
                {
                    if (current.data.Equals(data))
                    {
                        return current;
                    }

                    current = current.next;
                }
            }

            return null;
        }

        /// <summary>
        /// Remove item from list
        /// </summary>
        /// <param name="item">Item for removing</param>
        /// <returns>True if item removed successfully</returns>
        public bool Remove(T item)
        {
            Node<T> temp = this.head;
            Node<T> prev = null;

            if (temp != null && temp.data.Equals(item))
            {
                this.head = temp.next;
                return true;
            }

            while (temp != null && !temp.data.Equals(item))
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return false;
            }

            prev.next = temp.next;

            return true;
        }

        /// <summary>
        /// Return all single linked list values
        /// </summary>
        /// <param name="list">linked list</param>
        /// <returns>list with values</returns>
        public IList<T> GetListValues()
        {
            Node<T> current = head;
            var listValues = new List<T>();
            while (current != null)
            {
                listValues.Add(current.data);
                current = current.next;
            }

            return listValues;
        }

        /// <summary>
        /// Get last node of the current list
        /// </summary>
        /// <typeparam name="T">current list</typeparam>
        /// <param name="linkedList"></param>
        /// <returns>last node of the list</returns>
        private Node<T> GetLastNode<T>(SingleLinkedList<T> singleLinkedList)
        {
            Node<T> temp = singleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }        
    }
}
