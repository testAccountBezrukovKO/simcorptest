using System.Collections.Generic;

namespace LinkedList.src
{
    public class DoubleLinkedList<T>
    {
        internal DNode<T> head;

        /// <summary>
        /// Add new item to the list
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            DNode<T> newNode = new DNode<T>(item);
            if (this.head == null)
            {
                newNode.prev = null;
                this.head = newNode;
                return;
            }

            DNode<T> lastNode = GetLastNode(this);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        /// <summary>
        /// Remove item from list
        /// </summary>
        /// <param name="item">Item for removing</param>
        /// <returns>True if item removed successfully</returns>
        public bool Remove(T item)
        {
            DNode<T> temp = this.head;
            DNode<T> prev = null;

            if (temp != null && temp.data.Equals(item))
            {
                this.head = temp.next;
                this.head.prev = null;
                return true;
            }

            while (temp != null && !temp.data.Equals(item))
            {
                temp = temp.next;               
            }

            if (temp == null)
            {
                return false;
            }

            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }

            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }                      

            return true;
        }

        /// <summary>
        /// Get node by its value
        /// </summary>
        /// <param name="data">Value for comparison</param>
        /// <returns>Node that contains incoming value</returns>
        public DNode<T> GetNodeByValue(T data)
        {
            if (data != null)
            {
                DNode<T> current = head;

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
        /// Return all single linked list values
        /// </summary>
        /// <param name="list">linked list</param>
        /// <returns>list with values</returns>
        public IList<T> GetListValues()
        {
            DNode<T> current = head;
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
        private DNode<T> GetLastNode<T>(DoubleLinkedList<T> linkedList)
        {
            DNode<T> temp = linkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            return temp;
        }        
    }
}
